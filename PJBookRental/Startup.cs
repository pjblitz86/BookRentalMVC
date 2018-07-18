using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PJBookRental.Startup))]
namespace PJBookRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
