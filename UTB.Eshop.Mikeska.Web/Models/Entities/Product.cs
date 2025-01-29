using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UTB.Eshop.Mikeska.Domain.Implementation.Validations;

namespace UTB.Eshop.Mikeska.Web.Models.Entities
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ID { get; set; }
        
        [NotMapped]
        [FileContent("image")]
        public virtual IFormFile Image { get; set; }

        [Required]
        [StringLength(255)]
        public string ImageSrc { get; set; }

        [StringLength(50)]
        public string NameCZ { get; set; }
        [StringLength(50)]
        public string NameEN { get; set; }
        [StringLength(4096)]
        public string DescriptionCZ { get; set; }

        [StringLength(4096)]
        public string DescriptionEN { get; set; }

        [Range(0, double.MaxValue)]
        public double Price { get; set; }
        [ForeignKey(nameof(Kategorie))]
        public int IdKategories { get; set; }
    }
}