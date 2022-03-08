using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBattles.Shared
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Enter a username Vato")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required Foo")] 
        public string Password { get; set; }
    }
}
