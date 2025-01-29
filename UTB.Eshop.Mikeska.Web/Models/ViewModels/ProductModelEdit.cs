using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UTB.Eshop.Mikeska.Web.Models.Entities;

namespace UTB.Eshop.Mikeska.Web.Models.ViewModels
{
    public class ProductModelEdit : Product
    {
        public IList<Kategorie> Kategories { get; set; }
    }
}
