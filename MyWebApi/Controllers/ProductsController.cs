using Entities;
using Logic;
using MyWebApi.Factory;
using MyWebApi.Mapper;
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

        public IHttpActionResult PostProduct([FromBody] string body)
        {
            var response = new Response();
            try
            {
                var productsComplete = JsonConvert.DeserializeObject<Products>(body);
                Products products = ProductsMapper.Map(productsComplete);
                logic.Add(products);
                response.entity = products;
            }
            catch (Exception ex)
            {
                response = ResponseFactory.Create(ex.GetType().Name, ex.StackTrace);
            }
            return Ok(response);
        }

        public IHttpActionResult PutUpdate([FromBody] string body)
        {
            var response = new Response();
            try
            {
                Products products = JsonConvert.DeserializeObject<Products>(body);
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
