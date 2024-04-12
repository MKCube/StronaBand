using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StronaZespol.Startup))]
namespace StronaZespol
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
