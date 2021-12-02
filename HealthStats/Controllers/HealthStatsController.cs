using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HealthStats.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthStatsController : ControllerBase
    {
        // GET: api/<HealthStatsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<HealthStatsController>/5
        [HttpGet("{id}")]
        public HealthStats Get(int id)
        {

            //int stepsWalked, int kilometersWalked, int caloriesBurned,
            //int maxHeartRate, int minHeartRate, int userRanking
            if (id == 1234)
                {
                    return new HealthStats(6700, 3.2f, 240, 132, 68, 45);
                }
                else
                {
                    return new HealthStats(12400, 6.4f, 490, 140, 72, 8);
                }
        }

        // POST api/<HealthStatsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HealthStatsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HealthStatsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
