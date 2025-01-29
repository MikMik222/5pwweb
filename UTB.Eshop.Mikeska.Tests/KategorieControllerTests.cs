using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



using Xunit;
using Moq;

using UTB.Eshop.Mikeska.Web.Areas.Security.Controllers;

using UTB.Eshop.Mikeska.Web.Models.ApplicationServices.Abstraction;
using UTB.Eshop.Mikeska.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using UTB.Eshop.Mikeska.Web.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.IO;
using UTB.Eshop.Mikeska.Domain.Abstraction;
using UTB.Eshop.Mikeska.Tests.Helpers;
using UTB.Eshop.Mikeska.Web.Areas.Admin.Controllers;
using UTB.Eshop.Mikeska.Web.Models.Database;
using UTB.Eshop.Mikeska.Web.Models.Entities;

namespace UTB.Eshop.Mikeska.Tests
{
    public class KategorieControllerTests
    {
        [Fact]
        public async Task Category_ValidSuccess()
        {


            DbContextOptions options = new DbContextOptionsBuilder<EshopDbContext>()
                                       .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                                       .Options;
            var databaseContext = new EshopDbContext(options);
            databaseContext.Database.EnsureCreated();
            databaseContext.Kategories.RemoveRange(databaseContext.Kategories);
            databaseContext.SaveChanges();

            KategorieController controller = new KategorieController(databaseContext);
            controller.ObjectValidator = new ObjectValidator(true);

            IActionResult iActionResult = null;

            Kategorie kategorie = new Kategorie() { ID=1,
            katCZ ="neco",
            katEN="something"};

            iActionResult = await controller.Create(kategorie);
            RedirectToActionResult redirect = Assert.IsType<RedirectToActionResult>(iActionResult);
            Assert.Matches(redirect.ActionName, nameof(KategorieController.Index));
            Assert.Single(await databaseContext.Kategories.ToListAsync());
        }

    }
}
