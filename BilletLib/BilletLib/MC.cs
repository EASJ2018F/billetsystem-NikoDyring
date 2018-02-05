using System;

namespace BilletLib
{
    public class MC : Vehicle
    {

        public override string Nummerplade { get; set; }
        public override DayOfWeek Dato { get; set; }
        public override bool BrobizzBrugt { get; set; }
        public override bool Øresundsbroen { get; set; }
        public override int VehiclePrice { get; set; }

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

        public MC()
        {
            Dato = DateTime.Now.DayOfWeek;
            BrobizzBrugt = false;
        }
    }
}