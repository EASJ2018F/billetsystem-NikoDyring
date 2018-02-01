using System;

namespace BilletLib
{
    public abstract class Vehicle
    {

        public abstract string Nummerplade { get; set; }
        public abstract DayOfWeek Dato { get; set; }
        public abstract bool BrobizzBrugt { get; set; }
        public abstract bool WeekendRabat { get; set; }
        public abstract bool Øresundsbroen { get; set; }
        public abstract int Pris();
        public abstract string TypeAfKøretøj();
        public abstract int LængdeAfNummerplade();
        


    }
}