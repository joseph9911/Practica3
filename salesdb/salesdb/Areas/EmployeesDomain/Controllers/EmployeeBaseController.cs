using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using salesdb.Repository;

namespace salesdb.Areas.EmployeesDomain.Controllers
{
    public class EmployeeBaseController<T> : Controller where T : class
    {
        protected IRepository<T> _repository;
        public EmployeeBaseController()
        {
            _repository = new BaseRepository<T>();
        }
    }
}