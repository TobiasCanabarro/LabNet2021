using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class DogController : Controller
    {
        private readonly string _url = "https://dog.ceo/api/breeds/image/random";
        // GET: Dog
        public ActionResult Index()
        {
            var controller = new DogApiController();
            var result = controller.Get(_url);
            var dogView = new DogView
            {
                Message = result.Message
            };
            return View(dogView);
        }
    }
}