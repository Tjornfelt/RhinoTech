using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RhinoTech.App.Models.HelperModels
{
    public class ManagementProduct
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter something")]
        public string SKU { get; set; }

        [Required(ErrorMessage = "Please enter something")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter something")]
        public string Price { get; set; }

        [Required(ErrorMessage = "Please enter something")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter something")]
        public string Type { get; set; }
        public bool Discontinued { get; set; }

        [Required(ErrorMessage = "Please enter something")]
        public string Shelf { get; set; }

        [Required(ErrorMessage = "Please enter something")]
        public int Amount { get; set; }
    }
}