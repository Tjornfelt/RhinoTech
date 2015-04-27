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
                List<Companys> Companies = null;
                using (var context = new RCMSEntities())
                {
                    return context.Companys.ToList();
                    return Companies;
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
        internal static string GetShelfByProductID(int ID)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    return context.WarehouseShelfs.FirstOrDefault(x => x.ProductID == ID).Shelf;
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
        internal static void UpdateCustomer(Customers customer)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    Customers dbUser = context.Customers.FirstOrDefault(x => x.ID == customer.ID);
                    //Map the editted product to the dbProduct
                    dbUser.CompanyID = customer.CompanyID;
                    dbUser.Date = customer.Date;
                    dbUser.FirstName = customer.FirstName;
                    dbUser.LastName = customer.LastName;
                    dbUser.PhoneAreaCode = customer.PhoneAreaCode;
                    dbUser.PhonenNumber = customer.PhonenNumber;
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
    

