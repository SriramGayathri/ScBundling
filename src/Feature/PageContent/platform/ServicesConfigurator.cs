using Feature.PageContent.Controllers;
using Feature.PageContent.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Sitecore.DependencyInjection;

namespace Feature.PageContent
{
    public class ServicesConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {


            serviceCollection.Replace(ServiceDescriptor.Scoped(typeof(FormController),
                typeof(FormController)));

            serviceCollection.AddTransient<IFeedbackRepository, FeedbackRepository>();

            

            
        }
    }
}