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
        internal static List<Companys> GetCompanies()
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    return context.Companys.ToList();
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
            return null;
        }
        internal static List<OrdersItems> GetOrderItemsForOrder(int ID)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    return context.OrdersItems.Where(x => x.OrderID == ID).ToList();

                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
            return null;
        }
        internal static Products GetProductByID(int ID)
        {
            try
            {
                Products product = null;
                using (var context = new RCMSEntities())
                {
                    product = context.Products.FirstOrDefault(x => x.ID == ID);
                    return product;
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
            return null;
        }
        internal static Companys GetCompanyByID(int ID)
        {
            try
            {
                Companys company = null;
                using (var context = new RCMSEntities())
                {
                    company = context.Companys.FirstOrDefault(x => x.ID == ID);
                    return company;
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
            catch (Exception)
            {
                //Making sure app doesn't crash if connection fails.
            }
            return null;
        }
        internal static int GetShelfAmountByProductID(int productID)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    return context.WarehouseShelfs.FirstOrDefault(x => x.ProductID == productID).Amount;
                }
            }
            catch (Exception)
            {
                //Making sure app doesn't crash if connection fails.
            }
            return 0;
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
        internal static Orders GetOrderByID(int ID)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    return context.Orders.FirstOrDefault(x => x.ID == ID);

                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
            return null;
        }
        internal static void UpdateUser(Users user)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    Users dbUser = context.Users.FirstOrDefault(x => x.ID == user.ID);
                    //Map the editted product to the dbProduct
                    dbUser.FirstName = user.FirstName;
                    dbUser.LastName = user.LastName;
                    dbUser.Initials = user.Initials;
                    dbUser.Password = user.Password;
                    dbUser.isAdmin = user.isAdmin;
                    dbUser.isSalesPerson = user.isSalesPerson;
                    dbUser.isWorker = user.isWorker;

                    context.Entry(dbUser).State = System.Data.Entity.EntityState.Modified;

                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                throw e;
            }
        }
        internal static void UpdateProduct(Products product)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    Products dbProduct = context.Products.FirstOrDefault(x => x.ID == product.ID);
                    //Map the editted product to the dbProduct
                    dbProduct.Name= product.Name;
                    dbProduct.SKU = product.SKU;
                    dbProduct.Type = product.Type;
                    dbProduct.Description = product.Description;
                    //Technically, a product can have many shelf locations. For this exercise though, we always have 1. Select the first and update the values.
                    dbProduct.WarehouseShelfs.FirstOrDefault().Amount = product.WarehouseShelfs.FirstOrDefault().Amount;
                    dbProduct.WarehouseShelfs.FirstOrDefault().Shelf = product.WarehouseShelfs.FirstOrDefault().Shelf;
                    /*
                    dbProduct.isSalesPerson = product.isSalesPerson;
                    dbProduct.isWorker = product.isWorker;*/

                    context.Entry(dbProduct).State = System.Data.Entity.EntityState.Modified;

                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                throw e;
            }
        }
        internal static void UpdateCustomer(Customers customer)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    Customers dbCustomer = context.Customers.FirstOrDefault(x => x.ID == customer.ID);
                    //Map the editted product to the dbProduct
                    dbCustomer.CompanyID = customer.CompanyID;
                    dbCustomer.Date = customer.Date;
                    dbCustomer.FirstName = customer.FirstName;
                    dbCustomer.LastName = customer.LastName;
                    dbCustomer.PhoneAreaCode = customer.PhoneAreaCode;
                    dbCustomer.PhonenNumber = customer.PhonenNumber;
                    context.Entry(dbCustomer).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                throw e;
            }
        }
        internal static void UpdateCompany(Companys company)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    Companys dbCompany = context.Companys.FirstOrDefault(x => x.ID == company.ID);
                    //Map the editted product to the dbProduct
                    dbCompany.State = company.State;
                    dbCompany.Postalcode = company.Postalcode;
                    dbCompany.Country = company.Country;
                    dbCompany.CompanyName = company.CompanyName;
                    dbCompany.City = company.City;
                    dbCompany.Address = company.Address;
                    context.Entry(dbCompany).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                throw e;
            }
        }
        internal static void UpdateOrderItemShipped(bool shipped,int ID)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    OrdersItems dbOrderitem = context.OrdersItems.FirstOrDefault(x => x.ID == ID);
                    //Map the editted product to the dbProduct
                    dbOrderitem.isShipped = shipped;
                    context.Entry(dbOrderitem).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                throw e;
            }
        }
        internal static void AddUser(Users user)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    // add the new user 
                    context.Users.Add(user);
                    // Then save the changes
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                throw e;
            }
        }
        internal static void AddCustomer(Customers customers)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    // add the new user 
                    context.Customers.Add(customers);
                    // Then save the changes
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                throw e;
            }
        }
        internal static void AddCompany(Companys company)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    // add the new user 
                    context.Companys.Add(company);
                    // Then save the changes
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                throw e;
            }
        }
        internal static void AddOrder(Orders order)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    // add the new user 
                    context.Orders.Add(order);
                    context.OrdersItems.AddRange(order.OrdersItems);
                    // Then save the changes
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                throw e;
            }
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
    }
}
    

