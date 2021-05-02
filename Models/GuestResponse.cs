using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppMvc.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter your name")]
        [RegularExpression(pattern:".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set;    }
        [Required(ErrorMessage = "Please enter you phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Please specify whethe  you will attend")]
        public bool? WillAttend { get; set;  }
    }
}
