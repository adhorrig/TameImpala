using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TameImpala.Startup))]
namespace TameImpala
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
