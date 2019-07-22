using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(HRA.StartupOwin))]

namespace HRA
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
