using System.Text;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using Taxually.TechnicalTest.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Taxually.TechnicalTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VatRegistrationController : ControllerBase
    {
        /// <summary>
        /// Registers a company for a VAT number in a given country
        /// </summary>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] VatRegistrationRequest request)
        {
            switch (request.Country.CountryName)
            {
                case "GB":
                    // GB has an API to register for a VAT number
                    var httpClient = new TaxuallyHttpClient();
                    await httpClient.PostAsync(request);
                    break;
                case "FR":
                    var excelQueueClient = new TaxuallyQueueClient();
                    await excelQueueClient.EnqueueAsync(true, request);
                    break;
                case "DE":
                    var xmlQueueClient = new TaxuallyQueueClient();
                    await xmlQueueClient.EnqueueAsync(false, request);
                    break;
                default:
                    return BadRequest("Country is not supported");

            }

            return Ok();
        }
    }
}
