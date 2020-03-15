using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RYoshiga.Demo.Domain;

namespace RYoshiga.Demo.WebApi.Controllers
{
    public class DeliveryOptionsController : Controller
    {
        public async Task<ActionResult> GetFor(string countryCode)
        {
            await Task.CompletedTask;

            return Ok(new List<DeliveryOptionResponse>());
        }
    }
}
