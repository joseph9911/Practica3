using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(salesdb.Startup))]
namespace salesdb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
