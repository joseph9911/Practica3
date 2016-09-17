using salesdb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace salesdb.Areas.EmployeesDomain.Controllers
{
    public class EmployeeController : EmployeeBaseController<Employees>
    {
        public ActionResult Index()
        {
            return View(_repository.PaginatedList((x => x.EmployeeID), 1, 15));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employees employee)
        {
            if (!ModelState.IsValid) return View(employee);

            _repository.Add(employee);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var employee = _repository.GetById(x => x.EmployeeID == id);
            if (employee == null) return RedirectToAction("Index");
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employees employee)
        {
            if (!ModelState.IsValid) return View(employee);
            _repository.Update(employee);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var employee = _repository.GetById(x => x.EmployeeID == id);
            if (employee == null) return RedirectToAction("Index");
            return View(employee);
        }

        [HttpPost]
        public ActionResult Delete(Employees employee)
        {
            employee = _repository.GetById(x => x.EmployeeID == employee.EmployeeID);
            _repository.Delete(employee);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var employee = _repository.GetById(x => x.EmployeeID == id);
            if (employee == null) return RedirectToAction("Index");
            return View(employee);
        }
    }
}