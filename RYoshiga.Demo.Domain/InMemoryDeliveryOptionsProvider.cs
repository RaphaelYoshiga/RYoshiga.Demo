using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RYoshiga.Demo.Domain
{
    public class InMemoryDeliveryOptionsProvider :IRawDeliveryOptionsProvider
    {
        public Task<IEnumerable<RawDeliveryOption>> FetchBy(string countryCode)
        {
            IEnumerable<RawDeliveryOption> rawDeliveryOptions = new List<RawDeliveryOption>()
            {
                new RawDeliveryOption
                {
                    DaysToDispatch = 0,
                    DaysToDeliver = 1,
                    Name = "Next Day Delivery",
                    Price = 10
                },
                new RawDeliveryOption
                {
                    DaysToDispatch = 2,
                    DaysToDeliver = 2,
                    Name = "Standard Delivery",
                    Price = 2
                }
            };
            return Task.FromResult(rawDeliveryOptions);
        }
    }
}
