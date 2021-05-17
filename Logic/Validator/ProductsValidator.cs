using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Validator
{
    public class ProductsValidator
    {
        private static readonly int _max_length = 40;
        private static readonly int _min_length = 1;

        /* Este metodo se usa para validar la entra de datos del Update */
        public bool isValid(Products products)
        {
            return isProductNameValid(products.ProductName) && isProductIDValid(products.ProductID)
                && isUnitPriceValid(products.UnitPrice) && isUnitsInStock(products.UnitsInStock);
        }

        /* Este metodo se usa para validar la entra de datos del Post */
        public bool isValidWithoutID(Products product)
        {
            return isProductNameValid(product.ProductName) && isUnitPriceValid(product.UnitPrice) 
                && isUnitsInStock(product.UnitsInStock);
        }

        public bool isProductIDValid(int productID)
        {
            return productID > 0;
        }

        public bool isProductNameValid(string productName)
        {
            return productName.Length > _min_length && productName.Length < _max_length && productName != "";
        }

        public bool isUnitPriceValid(decimal? unitPrice)
        {
            return unitPrice > 0;
        }

        public bool isUnitsInStock(decimal? unitsInStock)
        {
            return unitsInStock > 0;
        }
    }
}
