using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Kunde
    {
        public List<Vehicle> køretøjList;
        public double totalSum = 0;

        /// <summary>
        /// Udregner sum for alle køretøjer.
        /// </summary>
        /// <returns></returns>

        public double UdregnSum()
        {
            foreach (Vehicle køretøj in køretøjList)
            {
                totalSum += køretøj.Pris();
            }

            return totalSum;
        }
        
    }
}
