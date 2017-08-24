﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Critter.Web.Models
{
    /// <summary>
    /// User View Model used for both New User
    /// </summary>
    public class NewUserViewModel
    {
        [Required(ErrorMessage ="This field is required")]
        [Display(Name = "User Name:")]
        public string Username { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [MinLength(8, ErrorMessage ="Password must be atleast 8 characters containing an uppercase, lowercase, special char(#@..) and number. ")]
        [Display(Name = "Password:")]
        public string Password { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage ="Passwords do not match")]
        [Display(Name = "Confirm Password:")]
        public string ConfirmPassword { get; set; }             
    }
}