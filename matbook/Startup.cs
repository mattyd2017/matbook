using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(matbook.Startup))]
namespace matbook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
