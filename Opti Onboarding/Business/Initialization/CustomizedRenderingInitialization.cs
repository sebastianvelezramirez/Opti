using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using Opti_Onboarding.Business.Rendering;

namespace Opti_Onboarding.Business.Initialization
{
    /// <summary>
    /// Module for customizing templates and rendering.
    /// </summary>
    [ModuleDependency(typeof(InitializationModule))]
    public class CustomizedRenderingInitialization : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            // Implementations for custom interfaces can be registered here.
            context.ConfigurationComplete += (o, e) =>
                // Register custom implementations that should be used in favour of the default implementations
                context.Services.AddTransient<IContentRenderer, ErrorHandlingContentRenderer>()
                    .AddSingleton<AlloyContentAreaItemRenderer, AlloyContentAreaItemRenderer>();
        }

        public void Initialize(InitializationEngine context) =>
            context.Locate.Advanced.GetInstance<ITemplateResolverEvents>().TemplateResolved += TemplateCoordinator.OnTemplateResolved;

        public void Uninitialize(InitializationEngine context) =>
            context.Locate.Advanced.GetInstance<ITemplateResolverEvents>().TemplateResolved -= TemplateCoordinator.OnTemplateResolved;
    }
}
