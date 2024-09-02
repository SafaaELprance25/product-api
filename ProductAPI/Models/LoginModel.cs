using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Models
{
    public class LoginModel
    {

        [Required]
        public string userName { get; set; }

        [Required]
        public string password { get; set; }
    }
}
