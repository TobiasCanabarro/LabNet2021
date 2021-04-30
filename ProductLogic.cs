using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{


    public class ProductLogic : AMBLogic<Products>
    {
        public ProductLogic() : base()
        {

        }

        public override void Add(Products products)
        {
            try
            {
                GetNorthwindContext().Products.Add(products);
                GetNorthwindContext().SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }


        public override void Delete(int id)
        {
            Products product = null;

            try
            {
                product = GetNorthwindContext().Products.Find(id);
                GetNorthwindContext().Products.Remove(product);
                GetNorthwindContext().SaveChanges();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public override Products Get(int id)
        {
            Products products = null;

            try
            {
                products = GetNorthwindContext().Products.Find(id);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return products;
        }


        public override List<Products> GetAall()
        {
            List<Products> customers = null;
            try
            {
                customers = GetNorthwindContext().Products.ToList();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return customers;
        }

        public override void Update(Products product)
        {
            Products updatedProduct = null;

            try
            {
                updatedProduct = GetNorthwindContext().Products.Find(product.ProductID);
                UpdateEntity(updatedProduct, product);
                GetNorthwindContext().SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        
        //Actualiza los datos viejos con los nuevos.
        private void UpdateEntity(Products updateProduct, Products product)
        {
            updateProduct.ProductID = product.ProductID;
            updateProduct.ProductName = product.ProductName;
            updateProduct.SupplierID = product.SupplierID;
            updateProduct.CategoryID = product.CategoryID;
            updateProduct.QuantityPerUnit = product.QuantityPerUnit;
            updateProduct.UnitPrice = product.UnitPrice;
            updateProduct.UnitsInStock = product.UnitsInStock;
            updateProduct.UnitsOnOrder = product.UnitsOnOrder;
            updateProduct.ReorderLevel = product.ReorderLevel;
            updateProduct.Discontinued = product.Discontinued;
            updateProduct.Order_Details = product.Order_Details;    
            updateProduct.Suppliers = product.Suppliers;
        }
    }
}
