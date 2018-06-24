﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLibrary.ViewModels
{
    public class ContactUsViewModel
    {
        [Required]
        [MinLength(5, ErrorMessage = "Minlength 5 is there!")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Exceeded max length!")]
        public string Message { get; set; }
    }
}
