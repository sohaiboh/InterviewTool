using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InterviewTool.Startup))]
namespace InterviewTool
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
