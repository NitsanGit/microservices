using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MobileAndInternetBill.Controllers
{

    public class Phone
    {
        public String phoneNumber { get; set; }
    }


    [Route("api/[controller]")]
    [ApiController]
    public class MobileBillController : ControllerBase
    {
        // GET api/<MobileBillController>/5
        [HttpGet("{phoneNumber}")]
        public PhoneAndInternet Get(String phoneNumber)
        {
            return new PhoneAndInternet(phoneNumber);
        }

        // POST api/<MobileBillController>
        [HttpPost]
        public PhoneAndInternet Post([FromBody] Phone phone)
        {
            return new PhoneAndInternet(phone.phoneNumber);
        }

        // PUT api/<MobileBillController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MobileBillController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
