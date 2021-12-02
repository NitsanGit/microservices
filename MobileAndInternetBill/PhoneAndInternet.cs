using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileAndInternetBill
{
    public class PhoneAndInternet
    {
        public int localCalls { get; set; }
        public String localData { get; set; }
        public int internationalMinutes { get; set; }
        public String roamingData { get; set; }
        public int internationalCallCharges { get; set; }
        public int localCallCharges { get; set; }
        public int localDataCharges { get; set; }
        public int internationalDataCharges { get; set; }
        public int currentBill { get; set; }
        public int pastBalance { get; set; }
        public int paymentReceived { get; set; }
        public int totalDue { get; set; }
        public String paymentDueDate { get; set; }

        public PhoneAndInternet SetDetails(int localCalls = 100, String localData = "5.0 GB", int internationalMinutes = 100, String roamingData = "1 GB", int internationalCallCharges = 200, int localCallCharges = 140, int localDataCharges = 100, int internationalDataCharges = 100, int currentBill = 450, int pastBalance = 0, int paymentReceived = 0,  int totalDue = 0, String paymentDueDate = "31/11/2021" )
        {
            this.localCalls = localCalls;
            this.localData = localData;
            this.internationalMinutes = internationalMinutes;
            this.roamingData = roamingData;
            this.internationalCallCharges = internationalCallCharges;
            this.localCallCharges = localCallCharges;
            this.internationalDataCharges = internationalDataCharges;
            this.localDataCharges = localDataCharges;
            this.currentBill = currentBill;
            this.pastBalance = pastBalance;
            this.paymentReceived = paymentReceived;
            this.totalDue = totalDue;
            this.paymentDueDate = paymentDueDate;

            return this; 
        }
        public PhoneAndInternet(String phoneNumber)
        {
            if ("95959595".Equals(phoneNumber)) {
                this.SetDetails();
            } else if ("88888888".Equals(phoneNumber)) 
            {
                this.SetDetails(140, "14.5 GB", 200, "2 GB", 240, 140, 120, 80, 560, 20, 200, 360);
            } else
            {
                this.SetDetails(220, "18.5 GB", 330, "4 GB", 340, 160, 80, 96, 860, 20, 200, 760);
            }
        }
    }
}
