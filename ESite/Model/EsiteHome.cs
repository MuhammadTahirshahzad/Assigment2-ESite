using System.ComponentModel.DataAnnotations;

namespace ESite.Model
{
    public class EsiteHome
    {
        [Key]
        public string productName { get; set; }
        public string productID { get; set; }
        public string product_price { get; set; }
    }
}
