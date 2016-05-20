using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PizzaOrders.Startup))]
namespace PizzaOrders
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
