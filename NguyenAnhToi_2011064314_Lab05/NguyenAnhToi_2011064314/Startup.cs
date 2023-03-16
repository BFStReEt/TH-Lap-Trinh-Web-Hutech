using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenAnhToi_2011064314.Startup))]
namespace NguyenAnhToi_2011064314
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
