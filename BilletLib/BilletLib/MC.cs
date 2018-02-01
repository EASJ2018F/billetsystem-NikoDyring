using System;

namespace BilletLib
{
    public class MC : Vehicle
    {
        public override string Nummerplade { get; set; }
        public override DateTime Dato { get; set; }
        public override bool BrobizzBrugt { get; set; }
        public override bool WeekendRabat { get; set; }
        public override bool Øresundsbroen { get; set; }

        public override int Pris(int pris)
        {

            DayOfWeek dagenIDag = DateTime.Now.DayOfWeek;

            if ((dagenIDag == DayOfWeek.Friday) || (dagenIDag == DayOfWeek.Saturday) || (dagenIDag == DayOfWeek.Sunday) && !Øresundsbroen)
            {
                WeekendRabat = true;
            }

            if (WeekendRabat && BrobizzBrugt)
            {
                return pris - (5 * pris / 100) - (20 * pris / 100);
            }

            if (Øresundsbroen && BrobizzBrugt)
            {
                pris = 73;
                return pris;
            }

            if (BrobizzBrugt && !Øresundsbroen)
            {
                return pris - (5 * pris / 100);
            }
            else if (WeekendRabat)
            {
                return pris - (20 * pris / 100);
            }
            return pris;
        }

        public override string TypeAfKøretøj()
        {
            if (Øresundsbroen)
            {
                return "Øresund MC";
            }

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