using System.Web.Mvc;

namespace salesdb.Areas.CustomersDomain
{
    public class CustomersDomainAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "CustomersDomain";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "CustomersDomain_default",
                "CustomersDomain/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}