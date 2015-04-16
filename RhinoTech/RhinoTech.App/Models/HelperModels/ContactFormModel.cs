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

        [Required(ErrorMessage = "Feltet må ikke være tomt")]
        [Display(Name = "Indtast navn*")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Feltet må ikke være tomt")]
        [EmailAddress(ErrorMessage = "Din e-mail adresse er i et forkert format")]
        [Display(Name = "E-mail adresse*")]
        public string Email { get; set; }

        [Display(Name = "Telefon nr.")]
        public string Phone { get; set; }

        [Display(Name = "Adresse")]
        public string Address { get; set; }

        [Display(Name = "Postnr/By")]
        public string PostalCity { get; set; }

        [Required(ErrorMessage = "Feltet må ikke være tomt")]
        [Display(Name = "Besked*")]
        public string Message { get; set; }

        public string ThanksText { get; set; }

    }
}