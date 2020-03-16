using System.Collections;
using System.Collections.Generic;

namespace RYoshiga.Demo.Domain
{
    public interface IDeliveryOptionsResponseMapper
    {
        IEnumerable<DeliveryOptionResponse> MapFrom(IEnumerable<RawDeliveryOption> rawDeliveryOptions);
    }
}