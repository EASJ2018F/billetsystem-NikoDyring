using System;

namespace BilletLib
{
    public class MC : Vehicle
    {
        public override string Nummerplade { get; set; }
        public override DateTime Dato { get; set; }
        public override bool BrobizzBrugt { get; set; }
        public override bool WeekendRabat { get; set; }

        public override int Pris()
        {

            DayOfWeek dagenIDag = DateTime.Now.DayOfWeek;

            if((dagenIDag == DayOfWeek.Friday) || (dagenIDag == DayOfWeek.Saturday) || (dagenIDag == DayOfWeek.Sunday))
            {
                WeekendRabat = true;
            }

            if(WeekendRabat && BrobizzBrugt)
            {
                return 125 - (5 * 125 / 100) - (20 * 125 / 100);
            }

            if (BrobizzBrugt)
            {
                return 125 - (5 * 125 / 100);
            } else if(WeekendRabat)
            {
                return 125 - (20 * 125 / 100);
            }
            return 125;
        }

        public override string TypeAfKøretøj()
        {
            return "MC";
        }

        public override int LængdeAfNummerplade()
        {
            if (Nummerplade.Length > 7)
            {
                throw new ArgumentException("Nummerplade for lang.");
            }

            return Nummerplade.Length;
        }
    }
}