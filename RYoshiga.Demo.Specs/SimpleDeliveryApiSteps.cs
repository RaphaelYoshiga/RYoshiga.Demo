using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using RYoshiga.Demo.WebApi.Controllers;
using TechTalk.SpecFlow;

namespace RYoshiga.Demo.Specs
{
    [Binding]
    public class SimpleDeliveryApiSteps
    {
        public SimpleDeliveryApiSteps()
        {
        }

        [Given(@"I have those delivery options for country code")]
        public void GivenIHaveThoseDeliveryOptionsForCountryCode(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"the time is (.*)")]
        public void GivenTheTimeIs(string dateTime)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I ask for delivery options for (.*)")]
        public async Task WhenIAskForDeliveryOptionsFor(string countryCode)
        {
            var hostBuilder = new WebApiSpecHostBuilder();
            var host = hostBuilder.Build();

            var deliveryOptionsController = (DeliveryOptionsController)host.Services.GetRequiredService(typeof(DeliveryOptionsController));

            await deliveryOptionsController.GetFor(countryCode);
        }

        [Then(@"I get those delivery options")]
        public void ThenIGetThoseDeliveryOptions(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
