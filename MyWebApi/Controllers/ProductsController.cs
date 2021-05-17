using Entities;
using Logic;
using MyWebApi.Factory;
using MyWebApi.Mapper;
using MyWebApi.Models.ModelResponse;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MyWebApi.Controllers
{   
   [EnableCors(origins: "http://localhost:4200", headers:"*", methods:"*")]
    public class ProductsController : ApiController
    {
        private readonly ProductLogic logic = new ProductLogic();

        public IEnumerable<Products> Get()
        {
            return logic.GetAll();
        }

        public IHttpActionResult Get(int id)
        {
            var products = new Products();
            Response response = new Response();
     
            try
            {
                products = logic.Get(id);
                Products mapProd = ProductsMapper.Map(products);
                response.entity = mapProd;
            }
            catch (Exception ex)
            {
                response = ResponseFactory.Create(ex.GetType().Name, ex.StackTrace);
            }
            return Ok(response);
        }

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
        //[FromBody] string body
        public IHttpActionResult PostProduct(Products products)
        {
            var response = new Response();
            try
            {
                //var productsComplete = JsonConvert.DeserializeObject<Products>(body);
                //Products products = ProductsMapper.Map(productsComplete);
                logic.Add(products);
                //response.entity = products;
            }
            catch (Exception ex)
            {
                response = ResponseFactory.Create(ex.GetType().Name, ex.StackTrace);
            }
            return Ok(response);
        }

        public IHttpActionResult PutUpdate(Products products)
        {
            var response = new Response();
            try
            {
                //Products products = JsonConvert.DeserializeObject<Products>(body);
                logic.Update(products);
            }
            catch (Exception ex)
            {
                response = ResponseFactory.Create(ex.GetType().Name, ex.StackTrace);
            }
            return Ok(response);
        }
    }
}
