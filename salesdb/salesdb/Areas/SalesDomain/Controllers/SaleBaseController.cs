using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using salesdb.Repository;
using salesdb.Filters;

namespace salesdb.Areas.SalesDomain.Controllers
{
    [ExceptionControl]
    [AuditControl]
    public class SaleBaseController<T> : Controller where T : class
    {
        protected IRepository<T> _repository;
        public SaleBaseController()
        {
            _repository = new BaseRepository<T>();
        }
    }
}