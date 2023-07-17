using Microsoft.AspNetCore.Http;

namespace PizzapanPresentationLayer.Models
{
    public class ImageFileViewModel
    {
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
    }
}
