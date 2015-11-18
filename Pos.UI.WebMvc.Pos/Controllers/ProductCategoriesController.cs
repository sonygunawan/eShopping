using Pos.Domain;
using Pos.Infras.Data.EFRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pos.UI.WebMvc.Pos.Controllers
{
    public class ProductCategoriesController : Controller
    {
        private ProductCategoriesService service;
        
        public ProductCategoriesController()
        {
            this.service = new ProductCategoriesService(new ProductCategoriesEFRepository());
        }
        //
        // GET: /ProductCategories/
        public ActionResult Index()
        {
            var productCategories = service.GetAll();

            return View(productCategories);
        }

        //
        // GET: /ProductCategories/Details/5
        public ActionResult Details(int id)
        {
            var productCategories = service.GetById(id);
            return View(productCategories);
        }

        //
        // GET: /ProductCategories/Create
        public ActionResult Create()
        {
            var count = service.GetCount();
            var productCategories = new ProductCategories { Id = count, Code = "C" + (count + 1) };
            return View(productCategories);
        }

        //
        // POST: /ProductCategories/Create
        [HttpPost]
        public ActionResult Create(ProductCategories productCategories)
        {
            try
            {

                service.Save(productCategories);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ProductCategories/Edit/5
        public ActionResult Edit(int id)
        {
            var productCategories = service.GetById(id);
            return View(productCategories);
        }

        //
        // POST: /ProductCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(ProductCategories productCategories)
        {
            try
            {
                // TODO: Add update logic here
                service.Save(productCategories);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ProductCategories/Delete/5
        public ActionResult Delete(int id)
        {
            var productCategories = service.GetById(id);
            return View(productCategories);
        }

        //
        // POST: /ProductCategories/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collecction)
        {
            new ProductCategoriesEFRepository().Delete(id);

            return RedirectToAction("Index");

        }
	}
}