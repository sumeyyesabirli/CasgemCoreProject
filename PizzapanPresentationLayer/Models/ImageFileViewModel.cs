using Microsoft.AspNetCore.Http;

namespace PizzapanPresentationLayer.Models
{
    public class ImageFileViewModel
    {
        public string ImageURl { get; set; }
        public IFormFile Image { get; set; }
    }
}
