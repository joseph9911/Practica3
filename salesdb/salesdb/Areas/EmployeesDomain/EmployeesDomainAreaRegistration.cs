using System.Web.Mvc;

namespace salesdb.Areas.EmployeesDomain
{
    public class EmployeesDomainAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "EmployeesDomain";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "EmployeesDomain_default",
                "EmployeesDomain/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}