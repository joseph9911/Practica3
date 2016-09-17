using System.Web.Mvc;

namespace salesdb.Areas.SalesDomain
{
    public class SalesDomainAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SalesDomain";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "SalesDomain_default",
                "SalesDomain/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}