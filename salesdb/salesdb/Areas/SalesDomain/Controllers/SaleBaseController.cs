using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using salesdb.Repository;

namespace salesdb.Areas.SalesDomain.Controllers
{
    public class SaleBaseController<T> : Controller where T : class
    {
        protected IRepository<T> _repository;
        public SaleBaseController()
        {
            _repository = new BaseRepository<T>();
        }
    }
}