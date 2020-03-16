using System;

namespace RYoshiga.Demo.Domain
{
    public interface IDeliveryEstimator
    {
        DateTime EstimateDeliveryFor(RawDeliveryOption rawDeliveryOptions);
    }

    public class DeliveryEstimator : IDeliveryEstimator
    {
        public DateTime EstimateDeliveryFor(RawDeliveryOption rawDeliveryOptions)
        {
            return DateTime.Now;
        }
    }
}