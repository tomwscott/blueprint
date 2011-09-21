using Blueprint.Web.Controllers;
using Blueprint.Web.Services;

namespace Blueprint.Web.Configuration.Modules
{
    public interface ApplicationModule
    {
        void RegisterDependencies(SimpleContainer container);
    }

    public class Infrastructure : ApplicationModule
    {
        private Infrastructure()
        {
        }

        public static ApplicationModule Module
        {
            get { return new Infrastructure(); }
        }

        public void RegisterDependencies(SimpleContainer container)
        {
            container.Register<DefaultController>();
            container.Register<IClock, Clock>();
        }
    }
}