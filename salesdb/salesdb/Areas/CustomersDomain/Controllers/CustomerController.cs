using salesdb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace salesdb.Areas.CustomersDomain.Controllers
{
    public class CustomerController : CustomerBaseController<Customers>
    {
        public ActionResult Index()
        {
            return View(_repository.PaginatedList((x => x.CustomerID), 1, 15));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customers customer)
        {
            if (!ModelState.IsValid) return View(customer);
            
            _repository.Add(customer);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var customer = _repository.GetById(x => x.CustomerID == id);
            if (customer == null) return RedirectToAction("Index");
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customers customer)
        {
            if (!ModelState.IsValid) return View(customer);
            _repository.Update(customer);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var customer = _repository.GetById(x => x.CustomerID == id);
            if (customer == null) return RedirectToAction("Index");
            return View(customer);
        }

        [HttpPost]
        public ActionResult Delete(Customers customer)
        {
            customer = _repository.GetById(x => x.CustomerID == customer.CustomerID);
            _repository.Delete(customer);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var customer = _repository.GetById(x => x.CustomerID == id);
            if (customer == null) return RedirectToAction("Index");
            return View(customer);
        }
    }
}