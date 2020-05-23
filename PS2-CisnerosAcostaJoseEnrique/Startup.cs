using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PS2_CisnerosAcostaJoseEnrique.Startup))]
namespace PS2_CisnerosAcostaJoseEnrique
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
