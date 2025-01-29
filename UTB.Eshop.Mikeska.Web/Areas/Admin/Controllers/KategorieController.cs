using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UTB.Eshop.Mikeska.Domain.Abstraction;
using UTB.Eshop.Mikeska.Web.Models.Database;
using UTB.Eshop.Mikeska.Web.Models.Entities;
using UTB.Eshop.Mikeska.Web.Models.Identity;
using UTB.Eshop.Mikeska.Web.Models.ViewModels;

namespace UTB.Eshop.Mikeska.Web.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = nameof(Roles.Admin) + ", " + nameof(Roles.Manager))]
    public class KategorieController : Controller
    {
        readonly EshopDbContext eshopDb;

        public KategorieController(EshopDbContext eshopDbContext)
        {
            eshopDb = eshopDbContext;
        }
        public IActionResult Index()
        {
            List<Kategorie> kategories = eshopDb.Kategories.ToList();


            return View(kategories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Kategorie kategorie)
        {
            if (ModelState.IsValid)
            {

                ModelState.Clear();
                bool validated = TryValidateModel(kategorie);
                if (validated)
                {
                    eshopDb.Kategories.Add(kategorie);

                    eshopDb.SaveChanges();

                    return RedirectToAction(nameof(KategorieController.Index));
                }


            }

            return View(kategorie);
        }


        public IActionResult Edit(int ID)
        {
            Kategorie kategorie = eshopDb.Kategories.FirstOrDefault(kat => kat.ID == ID);

            if (kategorie != null)
            {
                return View(kategorie);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Kategorie kategorie)
        {
            Kategorie kate = eshopDb.Kategories.FirstOrDefault(cat => cat.ID == kategorie.ID);

            if (kate != null)
            {
                if (ModelState.IsValid)
                {

                    kate.katEN = kategorie.katEN;
                    kate.katCZ = kategorie.katCZ;

                    eshopDb.SaveChanges();

                    return RedirectToAction(nameof(KategorieController.Index));
                }
                else
                    return View(kategorie);
            }

            return NotFound();
        }


        public IActionResult Delete(int ID)
        {
            Kategorie kategorie = eshopDb.Kategories.FirstOrDefault(a => a.ID == ID);

            if (kategorie != null)
            {

                eshopDb.Kategories.Remove(kategorie);

                eshopDb.SaveChanges();

                return RedirectToAction(nameof(CarouselController.Index));
            }

            return NotFound();
        }
    }
}