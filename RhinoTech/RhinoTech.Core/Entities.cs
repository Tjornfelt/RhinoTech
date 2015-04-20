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
            try
            {
                //Student student = null;
                List<Products> products = null;
                using (var context = new RCMSEntities())
                {
                    products = context.Products.ToList();
                }
            }
            catch (Exception)
            {
                //Making sure app doesn't crash if connection fails.
            }
        }
    }
}
