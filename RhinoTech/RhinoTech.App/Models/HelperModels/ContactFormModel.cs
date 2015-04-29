using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RhinoTech.App.Models.HelperModels
{
    public class ContactFormModel
    {
        public string ID { get; set; }

        [Required(ErrorMessage = "Field must not be empty")]
        [Display(Name = "Name*")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Field must not be empty")]
        [EmailAddress(ErrorMessage = "Wrong email format")]
        [Display(Name = "Email*")]
        public string Email { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Postal code + City")]
        public string PostalCity { get; set; }

        [Required(ErrorMessage = "Field must not be empty")]
        [Display(Name = "Message*")]
        public string Message { get; set; }

        public string ThanksText { get; set; }

    }
}