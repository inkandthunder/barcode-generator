using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(barcode_generator.Startup))]
namespace barcode_generator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
