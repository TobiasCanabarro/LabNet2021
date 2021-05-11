using Entities;
using Logic;
using Microsoft.AspNetCore.Mvc;
using MyWebApi.Factory;
using MyWebApi.Models.ModelResponse;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace MyWebApi.Controllers
{
    public class ProductsController : ApiController
    {

        private readonly ProductLogic logic = new ProductLogic();

        // GET api/products

        public IEnumerable<Products> Get()
        {
            return logic.GetAll();
        }

        // GET api/products/1
        public IHttpActionResult Get(int id)
        {
            var products = new Products();
            Response response = new Response();
            
            try
            {
                products = logic.Get(id);
                Products mapProd = new Products 
                { ProductID = products.ProductID,
                    ProductName = products.ProductName,
                    UnitPrice = products.UnitPrice,
                    UnitsInStock = products.UnitsInStock
                };
                response.entity = mapProd;
            }
            catch (Exception ex)
            {
                response = ResponseFactory.Create(ex.GetType().Name, ex.StackTrace);
            }
            return Ok(response);
        }

        // POST api/products + json
        public IHttpActionResult Post([FromBody] string body)
        {
            Products products = JsonConvert.DeserializeObject<Products>(body);
            var response = new Response();
            try
            {
                logic.Add(products);
                response.entity = products;
            }
            catch (Exception ex)
            {
                response = ResponseFactory.Create(ex.GetType().Name, ex.StackTrace);
            }
            return Ok(response);
        }

        // DELETE api/products/1
        public IHttpActionResult Delete(int id)
        {
            var response = new Response();
            try
            {
                logic.Delete(id);
            }
            catch (Exception ex)
            {
                response = ResponseFactory.Create(ex.GetType().Name, ex.StackTrace);
            }
            return Ok(response);
        }
    }
}
