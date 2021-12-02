using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthStats
{
    public class HealthStats
    {

        public int stepsWalked { get; set; }

        public float kilometersWalked { get; set; }

        public int caloriesBurned { get; set; }

        public int maxHeartRate  { get; set; }

        public int minHeartRate { get; set; }

        public int userRanking { get; set;  }

        public HealthStats(int stepsWalked, float kilometersWalked, int caloriesBurned, int maxHeartRate, int minHeartRate, int userRanking)
        {
            this.stepsWalked = stepsWalked;
            this.kilometersWalked = kilometersWalked;
            this.caloriesBurned = caloriesBurned;
            this.maxHeartRate = maxHeartRate;
            this.minHeartRate = minHeartRate;
            this.userRanking = userRanking;
        }
    }
}
