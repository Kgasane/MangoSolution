using System.ComponentModel.DataAnnotations;

namespace FrondEnd.MangoApp.Models
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImgUrl { get; set; }
        public bool Member { get; set; }
        public double Value { get; set; }
    }
}
