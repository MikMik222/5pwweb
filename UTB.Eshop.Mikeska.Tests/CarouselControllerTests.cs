using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Xunit;
using Xunit.Abstractions;
using Moq;
using UTB.Eshop.Mikeska.Domain.Abstraction;
using UTB.Eshop.Mikeska.Web.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using UTB.Eshop.Mikeska.Tests.Helpers;
using UTB.Eshop.Mikeska.Web.Areas.Admin.Controllers;
using Microsoft.AspNetCore.Mvc;
using UTB.Eshop.Mikeska.Web.Models.Database;

namespace UTB.Eshop.Mikeska.Tests
{
    public class CarouselControllerTests
    {
        const string relativeCarouselDirectoryPath = "/img/Carousels";

        private readonly ITestOutputHelper _testOutputHelper;
        public CarouselControllerTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public async Task CarouselCreate_ValidSuccess()
        {
            // Arrange
            var fileCheckContent = new Mock<ICheckFileContent>();
            fileCheckContent.Setup(fcc => fcc.CheckFileContent(It.IsAny<IFormFile>(), It.IsAny<string>())).Returns(true);

            var fileCheckLength = new Mock<ICheckFileLength>();
            fileCheckLength.Setup(fcl => fcl.CheckFileLength(It.IsAny<IFormFile>(), It.IsAny<long>())).Returns(true);

            var fileUpload = new Mock<IFileUpload>();
            //fileUpload.Setup(fu => fu.ContentType).Returns("image");
            //fileUpload.Setup(fu => fu.FileLength).Returns(5_000_000);
            fileUpload.Setup(fu => fu.FileUploadAsync(It.IsAny<IFormFile>(), It.IsAny<string>())).Returns(() => Task.Run<string>(() => "img/carousel/UploadImageFile.png"));


            //Nainstalovan Nuget package: Microsoft.EntityFrameworkCore.InMemory
            //databazi vytvori v pameti
            //Jsou zde konkretni tridy, takze to neni uplne OK - mely by se vyuzit interface jako treba pres IUnitOfWork, IRepository<T>, nebo pres vlastni IDbContext
            //takto to ale v krizovych situacich taky jde :-)
            DbContextOptions options = new DbContextOptionsBuilder<EshopDbContext>()
                                       .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                                       .Options;
            var databaseContext = new EshopDbContext(options);
            databaseContext.Database.EnsureCreated();
            databaseContext.CarouselSlides.RemoveRange(databaseContext.CarouselSlides);
            databaseContext.SaveChanges();

            CarouselController controller = new CarouselController(databaseContext, fileUpload.Object, fileCheckContent.Object, fileCheckLength.Object);
            //zapnuti validace - kdyz je vyuzivana metoda TryValidateModel, tak je nutne toto uvest (true na vstupu znamena ignorovani validace, false znamena zahrnuti validace)
            controller.ObjectValidator = new ObjectValidator(true);



            IActionResult iActionResult = null;



            string content = "‰PNG" + "FakeImageContent";
            string fileName = "UploadImageFile.png";

            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory() + relativeCarouselDirectoryPath));

            //nastaveni fakeove IFormFile pomoci MemoryStream
            using (var ms = new MemoryStream())
            {
                using (var writer = new StreamWriter(ms))
                {
                    MockHelperFormFile iffMockHelper = new MockHelperFormFile(_testOutputHelper);
                    Mock<IFormFile> iffMock = iffMockHelper.MockIFormFile(ms, writer, fileName, content, "image/png");
                    CarouselSlideFileRequired testCarousel = GetTestCarouselItem(iffMock.Object);


                    //u testovani nevalidniho vstupu (pro unit testy) se pro oddeleni logiky validace a controlleru doporucuje primo pridat vlastni chybu do ModelState
                    //controller.ModelState.AddModelError(nameof(CarouselSlide.Image), $"{nameof(CarouselSlide.Image)} is not set");


                    //Act
                    //zavolani TryValidateModel - jedna se o nahradu validace vstupu HTTP requestu pred zavolanim akcni metody (pokud zapoznamkujete nastaveni controller.ObjectValidator, tak musite zapoznamkovat i toto)
                    //controller.TryValidateModel(testCarousel);
                    iActionResult = await controller.Create(testCarousel);

                }
            }

            // Assert
            RedirectToActionResult redirect = Assert.IsType<RedirectToActionResult>(iActionResult);
            Assert.Matches(redirect.ActionName, nameof(CarouselController.Index));
            //var viewResult = Assert.IsType<ViewResult>(iActionResult);
            //var model = Assert.IsAssignableFrom<CarouselItem>(viewResult.Model);


            //int carouselCount = (await databaseContext.CarouselItems.ToListAsync()).Count;
            //Assert.Equal(1, carouselCount);
            Assert.Single(await databaseContext.CarouselSlides.ToListAsync());

        }



        [Fact]
        public async Task CarouselCreate_InvalidFailure()
        {
            //zkuste doplnit tak, aby objekt pro CarouselItem nebyl validni, coz bude spravny vysledek testu ;-)

            //pozn. to aby test neprosel je v tuto chvili napsano schvalne, aby vas to upozornilo, ze mate jeste neco udelat
            var fileCheckContent = new Mock<ICheckFileContent>();
            fileCheckContent.Setup(fcc => fcc.CheckFileContent(It.IsAny<IFormFile>(), It.IsAny<string>())).Returns(true);

            var fileCheckLength = new Mock<ICheckFileLength>();
            fileCheckLength.Setup(fcl => fcl.CheckFileLength(It.IsAny<IFormFile>(), It.IsAny<long>())).Returns(true);

            var fileUpload = new Mock<IFileUpload>();

            fileUpload.Setup(fu => fu.FileUploadAsync(It.IsAny<IFormFile>(), It.IsAny<string>())).Returns(() => Task.Run<string>(() => "img/carousel/UploadImageFile.png"));


            DbContextOptions options = new DbContextOptionsBuilder<EshopDbContext>()
                                       .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                                       .Options;
            var databaseContext = new EshopDbContext(options);
            databaseContext.Database.EnsureCreated();
            databaseContext.CarouselSlides.RemoveRange(databaseContext.CarouselSlides);
            databaseContext.SaveChanges();

            CarouselController controller = new CarouselController(databaseContext, fileUpload.Object, fileCheckContent.Object, fileCheckLength.Object);
            controller.ObjectValidator = new ObjectValidator(true);



            IActionResult iActionResult = null;



            string content = "‰PNG" + "FakeImageContent";
            string fileName = "UploadImageFile.png";

            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory() + relativeCarouselDirectoryPath));

            //nastaveni fakeove IFormFile pomoci MemoryStream
            using (var ms = new MemoryStream())
            {
                using (var writer = new StreamWriter(ms))
                {
                    MockHelperFormFile iffMockHelper = new MockHelperFormFile(_testOutputHelper);
                    Mock<IFormFile> iffMock = iffMockHelper.MockIFormFile(ms, writer, fileName, content, "image/png");
                    CarouselSlideFileRequired testCarousel = GetTestCarouselItem(iffMock.Object);


                    //u testovani nevalidniho vstupu (pro unit testy) se pro oddeleni logiky validace a controlleru doporucuje primo pridat vlastni chybu do ModelState
                    controller.ModelState.AddModelError(nameof(testCarousel.Image), $"{nameof(testCarousel.Image)} is not set");

                    iActionResult = await controller.Create(testCarousel);

                }
            }


            int carouselCount = (await databaseContext.CarouselSlides.ToListAsync()).Count;
            Assert.Equal(0, carouselCount);
            Assert.Empty(await databaseContext.CarouselSlides.ToListAsync());
        }



        CarouselSlideFileRequired GetTestCarouselItem(IFormFile iff)
        {
            return new CarouselSlideFileRequired()
            {
                ImageSrc = null,
                ImageAltCZ = "obrazek",
                ImageAltEN = "image",
                Image = iff
            };
        }

    }
}
