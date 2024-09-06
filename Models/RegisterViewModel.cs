﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AuthIdentity.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="First name is Required")]
        [Display(Name ="First Name")]
        public string? FirstName { get; set; }

        [Display(Name ="Last Name")]
        public string? LastName { get; set; }

        [Required]
        [EmailAddress]
        [Remote(action: "IsEmailAvailable", controller:"Account")]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirmation password do not match.")]
        public string? ConfirmPassword { get; set; }
    }
}
