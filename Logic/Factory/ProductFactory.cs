using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Factory
{
    public class ProductFactory
    {
        /*Implemente el patron de diseño Factiry para encapsular la instancia del objeto*/
        public static Products Create(int productID, string productName, int? supplierID, int? categoryID, string quantityPerUnit,
            decimal? unitPrice, short? unitsInStock, short? unitsOnOrder, short? reorderLevel, bool discontinued)
        {
            return new Products(productID, productName, supplierID, categoryID, quantityPerUnit,
             unitPrice, unitsInStock, unitsOnOrder, reorderLevel, discontinued);
        }
        /*
         ProductID = productView.Id,
                   ProductName = productView.ProductName,
                   UnitPrice = productView.UnitPrice,
                   UnitsInStock = productView.UnitsInStock
         */
        public static Products Create(int productID, string productName, decimal? unitPrice, short? unitsInStock)
        {
            return new Products
            {
                ProductID = productID,
                ProductName = productName,
                UnitPrice = unitPrice,
                UnitsInStock = unitsInStock
            };
        }

        public static Products Create(string productName, decimal? unitPrice, short? unitsInStock)
        {
            return new Products
            {
                ProductName = productName,
                UnitPrice = unitPrice,
                UnitsInStock = unitsInStock
            };
        }
    }
}
