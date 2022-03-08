using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBattles.Shared
{
    public class UserRegister
    {
        [Required(ErrorMessage = "Enter you Email Vato"), EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter a Username Puto"), StringLength(16, ErrorMessage = "Your Username is too long Homie!")]
        public string Username { get; set; }
        public string Bio { get; set; }
        [Required(ErrorMessage = "Password is required Foo") , StringLength(100, MinimumLength = 6) ]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "The Passwords do not match Dawg!")]
        public string ConfirmPassword { get; set; }
        public int StartUnitId { get; set; } = 1;
        [Range(0, 1000, ErrorMessage = "Choose a number between 0 and 1000 Bruh")]
        public int Bananas { get; set; } = 100;
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        [Range(typeof(bool), "true", "true", ErrorMessage = "Only confirmed users can play you Custer!")]
        public bool IsConfirmed { get; set; } = true;
    }
}
