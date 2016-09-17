using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using salesdb.Repository;
using salesdb.Filters;

namespace salesdb.Areas.CustomersDomain.Controllers
{
    [ExceptionControl]
    [AuditControl]
    public class CustomerBaseController<T> : Controller where T : class
    {
        protected IRepository<T> _repository;
        public CustomerBaseController()
        {
            _repository = new BaseRepository<T>();
        }
    }
}