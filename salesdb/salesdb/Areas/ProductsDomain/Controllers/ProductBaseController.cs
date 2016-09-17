using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using salesdb.Repository;
using salesdb.Filters;

namespace salesdb.Areas.ProductsDomain.Controllers
{
    [ExceptionControl]
    [AuditControl]
    public class ProductBaseController<T> : Controller where T : class
    {
        protected IRepository<T> _repository;
        public ProductBaseController()
        {
            _repository = new BaseRepository<T>();
        }
    }
}