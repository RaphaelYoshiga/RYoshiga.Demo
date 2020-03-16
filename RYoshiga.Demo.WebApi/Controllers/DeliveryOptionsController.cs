﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RYoshiga.Demo.Domain;

namespace RYoshiga.Demo.WebApi.Controllers
{
    public class DeliveryOptionsController : Controller
    {
        private readonly IRawDeliveryOptionsProvider _rawDeliveryOptionsProvider;
        private readonly IDeliveryOptionsResponseMapper _deliveryOptionsResponseMapper;

        public DeliveryOptionsController(IRawDeliveryOptionsProvider rawDeliveryOptionsProvider,
            IDeliveryOptionsResponseMapper deliveryOptionsResponseMapper)
        {
            _deliveryOptionsResponseMapper = deliveryOptionsResponseMapper;
            _rawDeliveryOptionsProvider = rawDeliveryOptionsProvider;
        }

        public async Task<ActionResult> GetFor(string countryCode)
        {
            var rawDeliveryOptions = await _rawDeliveryOptionsProvider.FetchBy(countryCode);
            var deliveryOptions = _deliveryOptionsResponseMapper.MapFrom(rawDeliveryOptions);
            return Ok(deliveryOptions);
        }
    }
}
