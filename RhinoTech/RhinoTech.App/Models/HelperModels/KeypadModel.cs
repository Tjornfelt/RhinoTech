using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RhinoTech.App.Models.HelperModels
{
    public class KeypadModel
    {
        //[Required, Display(Name = "Passcode"), DataType(DataType.Password)]
        public string Password { get; set; }

        public string Id { get; set; }
    }
}