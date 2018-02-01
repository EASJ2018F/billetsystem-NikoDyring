using System;

namespace BilletLib
{
    public class MC : Vehicle
    {
        public override string Nummerplade { get; set; }
        public override DayOfWeek Dato { get; set; }
        public override bool BrobizzBrugt { get; set; }
        public override bool WeekendRabat { get; set; }
        public override bool Øresundsbroen { get; set; }

        public override int Pris()
        {

            Dato = DateTime.Now.DayOfWeek;

            if ((Dato == DayOfWeek.Friday) || (Dato == DayOfWeek.Saturday) || (Dato == DayOfWeek.Sunday) && !Øresundsbroen)
            {
                WeekendRabat = true;
            }

            if (Øresundsbroen && BrobizzBrugt)
            {
                
                return 73;
            }

            if (WeekendRabat && BrobizzBrugt && !Øresundsbroen)
            {
                return 125 - (5 * 125 / 100) - (20 * 125 / 100);
            }

            if(Øresundsbroen)
            {
                return 210;
            }

            if (BrobizzBrugt && !Øresundsbroen)
            {
                return 125 - (5 * 125 / 100);
            }
            else if (WeekendRabat)
            {
                return 125 - (20 * 125 / 100);
            }
            return 125;
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