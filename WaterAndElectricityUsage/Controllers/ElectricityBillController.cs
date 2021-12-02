using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WaterAndElectricityUsage
{
    [Route("api/UtilityBill")]
    [ApiController]
    public class ElectricityUasage : ControllerBase
    {
        // GET api/<ValuesController>/5
        [HttpGet("{billNumber}")]
        public ElectricityBill Get(int billNumber)
        {
            if (billNumber == 1234)
            {
                return new ElectricityBill(88, 82, 82, 88);
            }
            else
            {
                return new ElectricityBill(300, 96, 212, 98);
            }
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}