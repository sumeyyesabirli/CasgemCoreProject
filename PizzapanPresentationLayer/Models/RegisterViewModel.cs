using System.ComponentModel.DataAnnotations;

namespace PizzapanPresentationLayer.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Adı boş bırakmayınız ")]
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required(ErrorMessage = "Email boş bırakmayınız ")]
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Şifre uyuşmuyor")]
        public string ConfirmPassword{get; set;}

    }
}
