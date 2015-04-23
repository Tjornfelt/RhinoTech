using RhinoCRM.Core.Login;
using SHUtils.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RhinoCRM.Core.Entityframework
{
    internal class Entities
    {
        // 10.13.37.151 - sa/radmin - Rhino2015

        internal static RCredentials.securitytoken GetUserSecuretokenbyID(int ID)
        {

            Users user = null;
            using (var context = new RCMSEntities())
            {
                user = context.Users.FirstOrDefault(x => x.ID == ID);

                if (user.isSalesPerson) return RCredentials.securitytoken.isSales;
                if (user.isAdmin) return RCredentials.securitytoken.isAdmin;
                if (user.isWorker) return RCredentials.securitytoken.isWorker;
            }
            throw new NullReferenceException();
        }
        internal static List<Products> GetProducts()
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
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
            return null;
        }
        internal static List<Users> GetUsers()
        {
            try
            {
                List<Users> Users = null;
                using (var context = new RCMSEntities())
                {
                    Users = context.Users.ToList();
                    return Users;
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
            return null;
        }
        internal static List<Customers> GetCustomers()
        {
            try
            {
                List<Customers> Customers = null;
                using (var context = new RCMSEntities())
                {
                    Customers = context.Customers.ToList();
                    return Customers;
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
            return null;
        }
        internal static Products GetProductByID(int productID)
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
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
            return null;
        }
        internal static string GetShelfByProductID(int productID)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    return context.WarehouseShelfs.FirstOrDefault(x => x.ProductID == productID).Shelf;
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
            return null;
        }
        internal static Users VerifySQLUserByLogin(string Init, string pswrd)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    return context.Users.FirstOrDefault(x => x.Initials == Init && x.Password == pswrd);
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
            return null;
        }
        internal static Users GetUserByID(int ID)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    return context.Users.FirstOrDefault(x => x.ID == ID);

                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
            return null;
        }
        internal static Customers GetCustomersByID(int ID)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    return context.Customers.FirstOrDefault(x => x.ID == ID);

                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
            return null;
        }
        internal static async void UpdateUserByID(int ID,Users user)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    Users u = context.Users.FirstOrDefault(x => x.ID == ID);
                    u.FirstName = user.FirstName;
                    u.LastName = user.LastName;
                    u.Initials = user.Initials;
                    u.Password = user.Password;
                    u.isAdmin = user.isAdmin;
                    u.isSalesPerson = user.isSalesPerson;
                    u.isWorker = user.isWorker;
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
        }
    }
}
    

