using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fill_UserControl_DropDownList.Startup))]
namespace Fill_UserControl_DropDownList
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
