using System;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using RYoshiga.Demo.Domain;
using RYoshiga.Demo.WebApi.Controllers;
using TechTalk.SpecFlow;

namespace RYoshiga.Demo.Specs
{
    [Binding]
    public class SimpleDeliveryApiSteps
    {
        private readonly Mock<IClock> _clockMock;
        public SimpleDeliveryApiSteps()
        {
            _clockMock = new Mock<IClock>();
        }

        [Given(@"I have those delivery options for country code (.*)")]
        public void GivenIHaveThoseDeliveryOptionsForCountryCode(string countryCode, Table table)
        {
        }

        [Given(@"the time is (.*)")]
        public void GivenTheTimeIs(string dateTime)
        {
            var now = DateTime.ParseExact(dateTime, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            _clockMock.SetupGet(p => p.UtcNow)
                .Returns(now);
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
        }
    }
}
