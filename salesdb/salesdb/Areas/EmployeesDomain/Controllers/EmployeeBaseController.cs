using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using salesdb.Repository;
using salesdb.Filters;

namespace salesdb.Areas.EmployeesDomain.Controllers
{
    [ExceptionControl]
    [AuditControl]
    public class EmployeeBaseController<T> : Controller where T : class
    {
        protected IRepository<T> _repository;
        public EmployeeBaseController()
        {
            _repository = new BaseRepository<T>();
        }
    }
}