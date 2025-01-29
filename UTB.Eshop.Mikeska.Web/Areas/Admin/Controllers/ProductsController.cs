using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UTB.Eshop.Mikeska.Domain.Abstraction;
using UTB.Eshop.Mikeska.Web.Models.Database;
using UTB.Eshop.Mikeska.Web.Models.Entities;
using UTB.Eshop.Mikeska.Web.Models.Identity;
using UTB.Eshop.Mikeska.Web.Models.ViewModels;


namespace UTB.Eshop.Mikeska.Web.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = nameof(Roles.Admin) + ", " + nameof(Roles.Manager))]
    public class ProductsController : Controller
    {
        readonly EshopDbContext eshopDb;
        IFileUpload fileUpload;
        ICheckFileContent checkFileContent;
        ICheckFileLength checkFileLength;
        public ProductsController(EshopDbContext eshopDbContext,
                                    IFileUpload fileUpload,
                                    ICheckFileContent checkFileContent,
                                    ICheckFileLength checkFileLength)
        {
            eshopDb = eshopDbContext;
            this.fileUpload = fileUpload;
            this.checkFileContent = checkFileContent;
            this.checkFileLength = checkFileLength;
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await eshopDb.Products
                .FirstOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public IActionResult Index()
        {
            List<Product> products = eshopDb.Products.ToList();
            List<Kategorie> kategories = eshopDb.Kategories.ToList();

            ProductViewModel pr = new ProductViewModel()
            {
                Kategories = kategories,
                Products = products,
            };

            return View(pr);
        }

        public IActionResult Create()
        {
            List<Kategorie> kategories = eshopDb.Kategories.ToList();
            ProductModelEdit pr = new ProductModelEdit()
            {
                Kategories = kategories,


            };
            return View(pr);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductModelEdit product)
        {
            ModelState.Remove(nameof(Product.ImageSrc));
            if (ModelState.IsValid)
            {
                if (checkFileLength.CheckFileLength(product.Image, 5_000_000))
                {

                    fileUpload.ContentType = "image";
                    fileUpload.FileLength = 5_000_000;
                    product.ImageSrc = await fileUpload.FileUploadAsync(product.Image, Path.Combine("img", "item"));

                    ModelState.Clear();
                    bool validated = TryValidateModel(product);
                    if (validated)
                    {
                        eshopDb.Products.Add(product);

                        eshopDb.SaveChanges();

                        return RedirectToAction(nameof(ProductsController.Index));
                    }

                }
            }

            return View(product);
        }


        public IActionResult Edit(int ID)
        {
            Product product = eshopDb.Products.FirstOrDefault(productItem => productItem.ID == ID);

            if (product != null)
            {
                List<Kategorie> kategories = eshopDb.Kategories.ToList();
                ProductModelEdit pr = new ProductModelEdit()
                {
                    Price = product.Price,
                    NameCZ = product.NameCZ,
                    NameEN = product.NameEN,
                    DescriptionCZ = product.DescriptionCZ,
                    ID = product.ID,
                    DescriptionEN = product.DescriptionEN,
                    IdKategories = product.IdKategories,
                    Kategories = kategories,


                };
                return View(pr);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProductModelEdit product)
        {

            Product produ = eshopDb.Products.FirstOrDefault(productItem => productItem.ID == product.ID);
            //Product produ = products.Products[0];

            if (produ != null)
            {
                ModelState.Remove(nameof(Product.ImageSrc));
                if (ModelState.IsValid)
                {
                    if (product.Image != null)
                    {
                        if (checkFileLength.CheckFileLength(product.Image, 5_000_000))
                        {

                            fileUpload.ContentType = "image";
                            fileUpload.FileLength = 5_000_000;
                            product.ImageSrc = await fileUpload.FileUploadAsync(product.Image, Path.Combine("img", "item"));

                            ModelState.Clear();
                            if (TryValidateModel(product))
                            {
                                if (eshopDb.Products.Count(productItem => productItem.ImageSrc == produ.ImageSrc) == 1)
                                {
                                    System.IO.File.Delete("wwwroot" + produ.ImageSrc);
                                }
                                produ.ImageSrc = product.ImageSrc;
                            }
                            else
                            {
                                return View(produ);
                            }
                        }
                        else
                        {
                            return View(produ);
                        }
                    }
                    produ.Price = product.Price;
                    produ.DescriptionEN = product.DescriptionEN;
                    produ.NameCZ = product.NameCZ;
                    produ.NameEN=product.NameEN;
                    produ.DescriptionCZ = product.DescriptionCZ;
                    produ.IdKategories = product.IdKategories;
                    eshopDb.SaveChanges();

                    return RedirectToAction(nameof(CarouselController.Index));
                }
                else
                    return View(produ);

            }
            return NotFound();
        }




        public IActionResult Delete(int ID)
        {
            Product product = eshopDb.Products.FirstOrDefault(productItem => productItem.ID == ID);

            if (product != null)
            {
                if (eshopDb.Products.Count(productItem => productItem.ImageSrc == product.ImageSrc) == 1)
                {
                    System.IO.File.Delete("wwwroot" + product.ImageSrc);
                }
                eshopDb.Products.Remove(product);

                eshopDb.SaveChanges();

                return RedirectToAction(nameof(CarouselController.Index));
            }

            return NotFound();
        }
    }
}
