using Microsoft.Extensions.DependencyInjection;
using RYoshiga.Demo.Domain;

namespace RYoshiga.Demo.WebApi
{
    public class Ioc
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IDeliveryEstimator, DeliveryEstimator>();
            services.AddSingleton<IRawDeliveryOptionsProvider, InMemoryDeliveryOptionsProvider>();
            services.AddSingleton<IDeliveryOptionsResponseMapper, DeliveryOptionsResponseMapper>();
        }
    }


}