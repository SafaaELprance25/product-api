namespace ProductAPI.Models
{
    public class loginviewmodel
    {




        [EmailAddress]
        [Required]
        public string Email
        { get; set; }
        [Required]
        public string password { get; set; }

    }
    public class loginviewmodel
    {




        [EmailAddress]
        [Required]
        public string Email
        { get; set; }

        [Required]
        public string password { get; set; }
        [compare("password")]
        public string ConfirmPassword { get; set; }
    }
}