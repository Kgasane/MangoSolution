using System.ComponentModel.DataAnnotations;

namespace Mango.Services.ProductAPI.Model.Dto
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImgUrl { get; set; }
        public bool Member { get; set; }
        [Range(1, 1000)]
        public double Value { get; set; }
    }
}
