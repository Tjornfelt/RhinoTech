//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RhinoTech.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customers
    {
        public Customers()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int ID { get; set; }
        public int CompanyID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneAreaCode { get; set; }
        public int PhonenNumber { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Companys Companys { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
