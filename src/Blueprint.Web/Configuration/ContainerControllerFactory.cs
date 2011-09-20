using System.Web.Mvc;
using System.Web.Routing;

namespace Blueprint.Web.Configuration
{
    public class ContainerControllerFactory : DefaultControllerFactory
    {
        private readonly ApplicationConfiguration applicationConfiguration;

        public ContainerControllerFactory(ApplicationConfiguration applicationConfiguration)
        {
            this.applicationConfiguration = applicationConfiguration;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, System.Type controllerType)
        {
            if(controllerType != null)
            {
                return applicationConfiguration.Container.Get<Controller>(controllerType);
            }
            return base.GetControllerInstance(requestContext, controllerType);
        }
    }
}