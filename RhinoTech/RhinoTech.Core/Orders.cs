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
    
    public partial class Orders
    {
        public Orders()
        {
            this.OrdersItems = new HashSet<OrdersItems>();
        }
    
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public System.DateTime Date { get; set; }
        public int SalespersonID { get; set; }
        public int VAT { get; set; }
    
        public virtual Customers Customers { get; set; }
        public virtual Users Users { get; set; }
        public virtual ICollection<OrdersItems> OrdersItems { get; set; }
    }
}