using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoyaltyPoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoyaltyController : ControllerBase
    {
 
        // GET api/<LoyaltyController>/5
        [HttpGet("{customerID}")]
        public IEnumerable<Loyalty> Get(int customerID)
        {
            Loyalty[] LoyaltyPoints = new Loyalty[]
            {
                new Loyalty(400, "CoffeeMax","24/APR/2022", "www.coffeeday.com" ),
                new Loyalty(2850, "Zorro Apparel", "15/NOV/2022", "www.zorro.com" ),
                new Loyalty(2540, "BooksAreUs", "20/JAN/2024", "www.booksareus.com" ),
                new Loyalty(34850, "Contoso Airlines", "12/JULY/2022", "www.contoso.com" )
            };

            return LoyaltyPoints.ToArray();
        }
    }
}
