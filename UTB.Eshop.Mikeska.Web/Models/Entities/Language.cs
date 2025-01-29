namespace UTB.Eshop.Mikeska.Web.Models.Entities
{
    public class Language
    {
        public string language { get; set; } = "CZ";
        public static string languages { get; set; }
        public static void ChangeLan()
        {
            languages = "EN";
        }
    }


}
