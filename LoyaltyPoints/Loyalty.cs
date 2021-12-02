using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoyaltyPoints
{
    public class Loyalty
    {
        public int pointsBalance { get; set; }

        public String brandName { get; set;  }

        public String pointsExpiryDate { get; set;  }

        public String brandLogoURL { get; set; }

        public Loyalty(int pointsBalance, String brandName, String pointsExpiryDate, String brandLogoURL)
        {
            this.pointsBalance = pointsBalance;
            this.brandName = brandName;
            this.brandLogoURL = brandLogoURL;
            this.pointsExpiryDate = pointsExpiryDate;
        }
    }
}
