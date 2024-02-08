using System.ComponentModel.DataAnnotations;

namespace RecaptchaV3.Models
{
    public class User
    {
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Password")]
        public string Password { get; set; }

    }
}
