using System.Web.Mvc;

namespace salesdb.Areas.ProductsDomain
{
    public class ProductsDomainAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ProductsDomain";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ProductsDomain_default",
                "ProductsDomain/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}