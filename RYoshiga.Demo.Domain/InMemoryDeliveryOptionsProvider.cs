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
                new RawDeliveryOption()
                {
                    DaysToDeliver = 1,
                    DaysToDispatch = 1,
                    Name = "Next Day Delivery",
                    Price = 5
                }
            };
            return Task.FromResult(rawDeliveryOptions);
        }
    }
}
