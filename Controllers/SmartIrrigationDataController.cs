using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartIrrigationDataApi.Models;

namespace SmartIrrigationDataApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SmartIrrigationDataController : ControllerBase
    {
        
        private readonly CustomerDbContext _context;
        private readonly ILogger<SmartIrrigationDataController> _logger;

        public SmartIrrigationDataController(ILogger<SmartIrrigationDataController> logger,CustomerDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("GetCustomerData")]
        public CustomerInfo GetCustomerData(string customerId)
        {
           
           CustomerInfo customerInfo=_context.CustomerInfoData.Find(customerId);
           return customerInfo;
        }

        [HttpGet]
        [Route("GetBioConfiguration")]
        public BioConfiguration GetBioConfiguration()
        {
           BioConfiguration bioconfiguration =new BioConfiguration() {
               PlantID = "TestPlantId",
               OptimalWaterVolumn = 20
           };
           return bioconfiguration;
        }

        [HttpPost]
        [Route("PostCustomerData")]
        public async Task<ActionResult<CustomerInfo>> PostCustomerData(CustomerInfo customerinfo)
        {
            _context.CustomerInfoData.Add(customerinfo);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCustomerData), new { id = customerinfo.CustomerID }, customerinfo);
        }
    }
}
