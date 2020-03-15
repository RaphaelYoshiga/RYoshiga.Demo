using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RYoshiga.Demo.WebApi.Controllers
{
    public class DeliveryOptionsController : Controller
    {
        public async Task<ActionResult> GetFor(string countryCode)
        {
            await Task.CompletedTask;

            return Ok();
        }
    }
}
