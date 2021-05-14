using Entities;
using MyWebApi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApi.Mapper
{
    public class ProductsMapper
    {
        //Con esta metodo solo me quedo con los campos necesarios.
        public static Products Map(Products products)
        {
            return new Products
            {
                ProductID = products.ProductID,
                ProductName = products.ProductName,
                UnitPrice = products.UnitPrice,
                UnitsInStock = products.UnitsInStock
            };
        }
    }
}