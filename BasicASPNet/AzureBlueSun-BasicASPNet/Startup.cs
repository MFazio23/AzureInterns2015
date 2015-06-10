using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureBlueSun_BasicASPNet.Startup))]
namespace AzureBlueSun_BasicASPNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
