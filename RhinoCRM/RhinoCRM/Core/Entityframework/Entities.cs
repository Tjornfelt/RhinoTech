using RhinoCRM.Core.Login;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RhinoCRM.Core.Entityframework
{
    internal class Entities
    {
        // 10.13.37.151 - sa/radmin - Rhino2015

        internal RCredentials.securitytoken GetUserSecuretoken(string Initials)
        {

                Users user = null;
                using (var context = new RCMSEntities())
                {
                    user = context.Users.FirstOrDefault(x => x.Initials == Initials);
                  
                    if (user.isSalesPerson) return RCredentials.securitytoken.isSales;
                    if (user.isAdmin) return RCredentials.securitytoken.isAdmin;
                    if (user.isWorker) return RCredentials.securitytoken.isWorker;
                }
                throw new NullReferenceException();
            
        }
        internal List<Products> GetProducts()
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

        internal Products GetProductByID(int productID)
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

        internal string GetShelfByProductID(int productID)
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
