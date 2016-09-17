using salesdb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace salesdb.Areas.SalesDomain.Controllers
{
    public class SaleController : SaleBaseController<Sales>
    {
        public ActionResult Index()
        {
            return View(_repository.PaginatedList((x => x.SalesID), 1, 15));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Sales sale)
        {
            if (!ModelState.IsValid) return View(sale);

            _repository.Add(sale);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var sale = _repository.GetById(x => x.SalesID == id);
            if (sale == null) return RedirectToAction("Index");
            return View(sale);
        }

        [HttpPost]
        public ActionResult Edit(Sales sale)
        {
            if (!ModelState.IsValid) return View(sale);
            _repository.Update(sale);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var sale = _repository.GetById(x => x.SalesID == id);
            if (sale == null) return RedirectToAction("Index");
            return View(sale);
        }

        [HttpPost]
        public ActionResult Delete(Sales sale)
        {
            sale = _repository.GetById(x => x.SalesID == sale.SalesID);
            _repository.Delete(sale);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var sale = _repository.GetById(x => x.SalesID == id);
            if (sale == null) return RedirectToAction("Index");
            return View(sale);
        }
    }
}