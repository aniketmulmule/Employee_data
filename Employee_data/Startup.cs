using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Employee_data.Startup))]
namespace Employee_data
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
