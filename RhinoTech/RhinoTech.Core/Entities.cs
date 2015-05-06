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

        public List<Product> GetProducts()
        {
            try
            {
                List<Product> products = null;
                using (var context = new RCMSEntities())
                {
                    products = context.Products.ToList();
                    return products;
                }
            }
            catch (Exception)
            {
                //Making sure app doesn't crash if connection fails.
                return null;
            }
            
        }

        public Product GetProductByID(int productID)
        {
            try
            {
                Product product = null;
                using (var context = new RCMSEntities())
                {
                    product = context.Products.FirstOrDefault(x => x.ID == productID);
                    return product;
                }
            }
            catch (Exception)
            {
                //Making sure app doesn't crash if connection fails.
                return null;
            }
            
        }

        public bool UpdateProduct(Product edittedProduct)
        {
            try
            {
                Product dbProduct = null;
                using (var context = new RCMSEntities())
                {
                    dbProduct = context.Products.FirstOrDefault(x => x.ID == edittedProduct.ID);

                    //Map the editted product to the dbProduct
                    dbProduct.SKU = edittedProduct.SKU;
                    dbProduct.Name = edittedProduct.Name;
                    dbProduct.Price = edittedProduct.Price;
                    dbProduct.Type = edittedProduct.Type;
                    dbProduct.Description = edittedProduct.Description;

                    //Technically, a product can have many shelf locations. For this exercise though, we always have 1. Select the first and update the values.
                    dbProduct.WarehouseShelfs.FirstOrDefault().Amount = edittedProduct.WarehouseShelfs.FirstOrDefault().Amount;
                    dbProduct.WarehouseShelfs.FirstOrDefault().Shelf = edittedProduct.WarehouseShelfs.FirstOrDefault().Shelf;

                    context.Entry(dbProduct).State = System.Data.Entity.EntityState.Modified;

                    context.SaveChanges();

                    return true;
                }
            }
            catch (Exception)
            {
                //Making sure app doesn't crash if connection fails.
                return false;
            }
            
        }

        public bool CreateProduct(Product product)
        {
            try
            {
                using (var context = new RCMSEntities())
                {
                    /*
                    WarehouseShelf shelf = new WarehouseShelf()
                    {
                        Amount = product.WarehouseShelfs.FirstOrDefault().Amount,
                        Shelf = product.WarehouseShelfs.FirstOrDefault().Shelf
                    };

                    product.WarehouseShelfs.Add(shelf);
                    */
                    context.Products.Add(product);

                    // 4) Then save the changes
                    context.SaveChanges();

                    

                    return true;
                }
            }
            catch (Exception ex)
            {
                //Making sure app doesn't crash if connection fails.
                return false;
            }
            
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
                return null;
            }
            
        }

        public int GetShelfAmountByProductID(int productID)
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
                return 0;
            }
            
        }

        public bool DeleteProduct(int productID)
        {
            try
            {
                Product dbProduct = null;
                using (var context = new RCMSEntities())
                {
                    dbProduct = context.Products.FirstOrDefault(x => x.ID == productID);

                    //Mark the product as discontinued - we dont ever delete products
                    dbProduct.Discontinued = true;

                    context.Entry(dbProduct).State = System.Data.Entity.EntityState.Modified;

                    context.SaveChanges();

                    return true;
                }
            }
            catch (Exception)
            {
                //Making sure app doesn't crash if connection fails.
                return false;
            }
            
        }

        public bool EnableProduct(int productID)
        {
            try
            {
                Product dbProduct = null;
                using (var context = new RCMSEntities())
                {
                    dbProduct = context.Products.FirstOrDefault(x => x.ID == productID);

                    //Mark the product as discontinued - we dont ever delete products
                    dbProduct.Discontinued = false;

                    context.Entry(dbProduct).State = System.Data.Entity.EntityState.Modified;

                    context.SaveChanges();

                    return true;
                }
            }
            catch (Exception)
            {
                //Making sure app doesn't crash if connection fails.
                return false;
            }
            
        }

        public bool AddLogEntry(string name, DateTime timestamp, string type, string message)
        {
            try
            {
                throw new NotImplementedException();
                return true; //In preparation for implementation
            }
            catch(Exception)
            {
                //Making sure app doesn't crash if connection fails.
                return false;
            }
            
        }
    }
}
