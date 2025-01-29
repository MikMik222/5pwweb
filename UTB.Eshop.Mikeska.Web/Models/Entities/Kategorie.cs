using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTB.Eshop.Mikeska.Web.Models.Entities
{
    [Table("Kategorie")]
    public class Kategorie
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [StringLength(25)]
        [Required]
        public string katCZ { get; set; }

        [StringLength(25)]
        [Required]
        public string katEN { get; set; }
    }
}
