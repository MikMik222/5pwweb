using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UTB.Eshop.Mikeska.Domain.Abstraction;
using UTB.Eshop.Mikeska.Domain.Implementation;
using UTB.Eshop.Mikeska.Web.Areas.Admin.Controllers;
using UTB.Eshop.Mikeska.Web.Models;
using UTB.Eshop.Mikeska.Web.Models.Database;
using UTB.Eshop.Mikeska.Web.Models.Entities;
using UTB.Eshop.Mikeska.Web.Models.ViewModels;

namespace UTB.Eshop.Mikeska.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly EshopDbContext eshopDb;
        public HomeController(ILogger<HomeController> logger, EshopDbContext eshopDbContext)
        {
            _logger = logger;
            eshopDb = eshopDbContext;
        }

        public IActionResult Description(int ID)
        {
            Product product = eshopDb.Products.FirstOrDefault(productItem => productItem.ID == ID);

            if (product != null)
            {
                return View(product);
            }

            return NotFound();
        }



        public IActionResult Index()
        {
            _logger.LogInformation("Hello, world!");
            List<CarouselSlide> carouselSlides = eshopDb.CarouselSlides.ToList();
            List<Product> products = eshopDb.Products.ToList();
            List<Kategorie> kategorie = eshopDb.Kategories.ToList();


            if (!HttpContext.Request.Cookies.ContainsKey("first_request"))
            {
                HttpContext.Response.Cookies.Append("first_request", "EN");
            }
            else
            {
                string s = HttpContext.Request.Cookies["first_request"];
                if (s == "EN" || s == "CZ")
                {
                    Language.languages = s;
                }
                else
                {
                    Language.languages = "EN";
                    HttpContext.Response.Cookies.Delete("first_request");
                    HttpContext.Response.Cookies.Append("first_request", "EN");
                }

            }
            HomeIndexViewModel hiVM = new HomeIndexViewModel()
            {
                CarouselSlides = carouselSlides,
                Products = products,
                Kategories = kategorie
            };

            return View(hiVM);
        }

        public ActionResult ChangeLanguage()
        {
            if (!HttpContext.Request.Cookies.ContainsKey("first_request"))
            {
                HttpContext.Response.Cookies.Delete("first_request");
            }
            if (Language.languages == "CZ")
            {
                HttpContext.Response.Cookies.Append("first_request", "EN");
                Language.languages = "EN";
            }
            else
            {
                HttpContext.Response.Cookies.Append("first_request", "CZ");
                Language.languages = "CZ";
            }
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult IndexFiltrace(int ID)
        {
            _logger.LogInformation("Hello, world!");
            List<Product> products = eshopDb.Products.Where(cat => cat.IdKategories == ID).ToList();
            List<Kategorie> kategorie = eshopDb.Kategories.ToList();


            HomeIndexViewModel hiVM = new HomeIndexViewModel()
            {
                CarouselSlides = null,
                Products = products,
                Kategories = kategorie
            };

            return View(hiVM);
        }
    }
}
