using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketTracking.WebApp.Models
{
    public class Login
    {
        [Display(Name = "Enter your Email ID")]
        [Required(ErrorMessage = "Email ID cannot be blank")]
        public string LoginId { get; set; }

        [Display(Name = "Enter your Password")]
        [Required(ErrorMessage = "Password cannot be blank")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
