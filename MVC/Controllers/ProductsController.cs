using Entities;
using Logic;
using Logic.Factory;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logic.Validator;
using Entities.Exception;

namespace MVC.Controllers
{
    public class ProductsController : Controller, IAction<ProductsView>
    {

        private readonly ProductLogic _productsLogic = new ProductLogic();
        private readonly string _index = "Index";
        private readonly string _error = "Error";

        public ActionResult Index()
        {
            List<Products> products = _productsLogic.GetAll();

            List<ProductsView> productsViews = products.Select(s => new ProductsView
            {
                Id = s.ProductID,
                ProductName = s.ProductName,
                UnitPrice = s.UnitPrice,
                UnitsInStock = s.UnitsInStock
            }).ToList();

            return View(productsViews);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(ProductsView productView)
        {
            ProductsValidator validator = new ProductsValidator();

            try
            {
                if (!validator.IsValid(productView.Id))
                {
                    return Update(productView);
                }            
                Products product = ProductFactory.Create(productView.ProductName, productView.UnitPrice, productView.UnitsInStock);
                _productsLogic.Add(product);
                
                return RedirectToAction(_index);
            }
            catch (Exception)
            {
                return RedirectToAction(_index, _error);
            }
        }

        public ActionResult Update(ProductsView productView)
        {
            try
            {
                Products product = ProductFactory.Create(productView.Id, productView.ProductName, productView.UnitPrice, productView.UnitsInStock);
                _productsLogic.Update(product);
                return RedirectToAction(_index);
            }
            catch (Exception)
            {
                return RedirectToAction(_index, _error);
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                _productsLogic.Delete(id);
                return RedirectToAction(_index);
            }
            catch (Exception)
            {
                return RedirectToAction(_index, _error);
            }
        }

    }
}