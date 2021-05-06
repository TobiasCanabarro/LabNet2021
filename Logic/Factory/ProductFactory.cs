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
    }
}
