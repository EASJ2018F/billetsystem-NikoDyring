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
            if (BrobizzBrugt)
            {
                return 5 * 125 / 100 + 125;
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