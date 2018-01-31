using System;

namespace BilletLib
{
    public class MC : Vehicle
    {
        public override string Nummerplade { get; set; }
        public override DateTime Dato { get; }

        public override int Pris()
        {
            return 125;
        }

        public override string TypeAfKøretøj()
        {
            return "MC";
        }

        public override int LængdeAfNummerplade()
        {
            if (Nummerplade.Length < 8)
            {
                throw new ArgumentException("Nummerplade for lang.");
            }

            return Nummerplade.Length;
        }
    }
}