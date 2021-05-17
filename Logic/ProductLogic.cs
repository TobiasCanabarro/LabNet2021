using Entities;
using Logic.Validator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{


    public class ProductLogic : AMBLogic<Products>
    {
        ProductsValidator validator = new ProductsValidator();

        public ProductLogic() : base()
        {

        }

        public override void Add(Products products)
        {
            
            try
            {
                if (validator.isValidWithoutID(products))
                {
                    GetNorthwindContext().Products.Add(products);
                    GetNorthwindContext().SaveChanges();
                }
                
            }
            catch (System.Exception)
            {
               
            }
        }

        public override void Delete(int id)
        {
            Products product = null;

            try
            {
                if (validator.isProductIDValid(id))
                {
                    product = GetNorthwindContext().Products.Find(id);
                    GetNorthwindContext().Products.Remove(product);
                    GetNorthwindContext().SaveChanges();
                }               
            }
            catch (InvalidOperationException )
            {
         
            }
        }

        public override Products Get(int id)
        {
            Products products = null;

            try
            {
                if (validator.isProductIDValid(id))
                {
                    products = GetNorthwindContext().Products.Find(id);
                }               
            }
            catch (InvalidOperationException)
            {
                
            }
            catch (System.Exception)
            {

            }
            return products;
        }


        public override List<Products> GetAll()
        {
            List<Products> products = null;
            try
            {
                products = GetNorthwindContext().Products.Take(5).ToList();
            }
            catch (ArgumentNullException)
            {
                
            }
            return products;
        }

        public override void Update(Products product)
        {
            Products updatedProduct = null;

            try
            {
                if (validator.isValid(product))
                {
                    updatedProduct = GetNorthwindContext().Products.Find(product.ProductID);
                    UpdateEntity(updatedProduct, product);
                    GetNorthwindContext().SaveChanges();
                }              
            }
            catch (System.Exception)
            {
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
