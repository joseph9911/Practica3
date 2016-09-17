using salesdb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace salesdb.Areas.ProductsDomain.Controllers
{
    public class ProductController : ProductBaseController<Products>
    {
        public ActionResult Index()
        {
            return View(_repository.PaginatedList((x => x.ProductID), 1, 15));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Products product)
        {
            if (!ModelState.IsValid) return View(product);

            _repository.Add(product);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var product = _repository.GetById(x => x.ProductID == id);
            if (product == null) return RedirectToAction("Index");
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Products product)
        {
            if (!ModelState.IsValid) return View(product);
            _repository.Update(product);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var product = _repository.GetById(x => x.ProductID == id);
            if (product == null) return RedirectToAction("Index");
            return View(product);
        }

        [HttpPost]
        public ActionResult Delete(Products product)
        {
            product = _repository.GetById(x => x.ProductID == product.ProductID);
            _repository.Delete(product);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var product = _repository.GetById(x => x.ProductID == id);
            if (product == null) return RedirectToAction("Index");
            return View(product);
        }
    }
}