using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SparkleandShine2.Startup))]
namespace SparkleandShine2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
