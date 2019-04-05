using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DBS_v1.ViewModels
{
    public class UserLoginVM
    {
        [Required(ErrorMessage = "Please Enter Username")]
        [Display(Name = "username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [Display(Name = "Password")]
        public string Password { get; set; } 
    }
}