using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoTech.Core
{
    public class Entities
    {
        // 10.13.37.151 - sa/radmin - Rhino2015

        public List<Products> GetProducts()
        {
            try
            {
                List<Products> products = null;
                using (var context = new RCMSEntities())
                {
                    products = context.Products.ToList();
                    return products;
                }
            }
            catch (Exception)
            {
                //Making sure app doesn't crash if connection fails.
            }
            return null;
        }

        public Products GetProductByID(int productID)
        {
            try
            {
                Products product = null;
                using (var context = new RCMSEntities())
                {
                    product = context.Products.FirstOrDefault(x => x.ID == productID);
                    return product;
                }
            }
            catch (Exception)
            {
                //Making sure app doesn't crash if connection fails.
            }
            return null;
        }

        public string GetShelfByProductID(int productID)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    return context.WarehouseShelfs.FirstOrDefault(x => x.ProductID == productID).Shelf;
                }
            }
            catch (Exception)
            {
                //Making sure app doesn't crash if connection fails.
            }
            return null;
        }
    }
}
