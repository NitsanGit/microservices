using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaterAndElectricityUsage
{
    public class ElectricityBill
    {
        public ElectricityBill(int currentBill, int pastBalance, int paymentReceived, int amountDue, int consumptionCharges=78, int meterRent=10, int reconcilliation=0, int fines = 0, int otherFees = 0)
        {
            this.currentBill = currentBill;
            this.pastBalance = pastBalance;
            this.paymentReceived = paymentReceived;
            this.totalAmountDue = amountDue;
            this.consumptionCharges = consumptionCharges; 
            this.meterRent = meterRent; 
            this.fines = fines; 
            this.otherFees = otherFees; 
            this.reconcilliation = reconcilliation;
        }

        public int currentBill { get; set; }

        public int pastBalance { get; set; }

        public int paymentReceived { get; set; }

        public int totalAmountDue { get; set;  }

        public int consumptionCharges { get; set;  }

        public int meterRent { get; set;  }

        public int reconcilliation { get; set; }

        public int fines { get; set; }

        public int otherFees { get; set; }
    }
}