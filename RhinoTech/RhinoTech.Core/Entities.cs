using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoTech.Core
{
    public class Entities
    {
        public void GetProducts()
        {
            //Student student = null;
            List<Products> test = null;
            using (var context = new RCMSEntities())
            {
                test = context.Products.ToList();
            }

            var testasd = "";
        }
    }
}
