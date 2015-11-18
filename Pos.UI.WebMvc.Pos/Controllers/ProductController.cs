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

    public class ProductController : Controller
    {
        //private PosContext ctx = new PosContext();
        private ProductService service;

        public ProductController()
        {
            this.service = new ProductService(new ProductEFRepository());
        }
        // GET: /Product/
        public ActionResult Index()
        {

            var products = service.GetAll();
            
            return View(products);
        }

        //
        // GET: /Product/Details/5
        public ActionResult Details(int id)
        {
            var product = service.GetById(id);
            return View(product);
        }

        //
        // GET: /Product/Create
        public ActionResult Create()
        {
            var count = service.GetCount();
            var product = new Product { Id = count, Code = "P" + (count + 1) };
            return View(product);
        }

        //
        // POST: /Product/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                
                service.Save(product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Product/Edit/5
        public ActionResult Edit(int id)
        {
            var product = service.GetById(id);
            return View(product);
        }

        //
        // POST: /Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            try
            {
                // TODO: Add update logic here
                service.Save(product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Product/Delete/5
        public ActionResult Delete(int id)
        {
            var product = service.GetById(id);
            return View(product);
        }

        //
        // POST: /Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collecction)
        {
            new ProductEFRepository().Delete(id);
            
            return RedirectToAction("Index");
            
        }
    }
}
