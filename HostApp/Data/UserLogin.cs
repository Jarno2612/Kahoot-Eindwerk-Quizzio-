using System;
using System.ComponentModel.DataAnnotations;
namespace HostApp.Data
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Please enter a email")] 
        public string Email { get; set; }
        [Required]

        public string Password { get; set; }

    }
}
