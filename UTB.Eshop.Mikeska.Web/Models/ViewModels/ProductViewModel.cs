using System;
using System.Collections.Generic;
using UTB.Eshop.Mikeska.Web.Models.Entities;

namespace UTB.Eshop.Mikeska.Web.Models.ViewModels
{
    public class ProductViewModel
    {
        public IList<Product> Products { get; set; }
        public IList<Kategorie> Kategories { get; set; }
    }
}