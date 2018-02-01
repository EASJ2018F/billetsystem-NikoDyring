using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil : Vehicle
    {
        public override string Nummerplade { get; set; }
        public override DayOfWeek Dato { get; set; }
        public override bool BrobizzBrugt { get; set; }
        public override bool WeekendRabat { get; set; }
        public override bool Øresundsbroen { get; set; }
        public override int VehiclePrice { get; set; }

        public override string TypeAfKøretøj()
        {
            if (Øresundsbroen)
            {
                return "Øresund Bil";
            }

            return "Bil";
        }

        public override int LængdeAfNummerplade()
        {
            if (Nummerplade.Length > 7 || Nummerplade.Length < 0)
            {
                throw new ArgumentException("Nummerplade for lang.");
            }

            return Nummerplade.Length;
        }

        public int WeekendRabatIBil()
        {
            if (!Øresundsbroen)
            {
                VehiclePrice = 240;
            }
            switch (Dato)
            {
                case DayOfWeek.Saturday:
                    if (!Øresundsbroen)
                    {
                        WeekendRabat = true;
                    }
                    break;
                case DayOfWeek.Sunday:
                    if (!Øresundsbroen)
                    {
                        WeekendRabat = true;
                    }
                    break;
            }

            if (WeekendRabat && BrobizzBrugt && !Øresundsbroen)
            {
                return VehiclePrice - (20 * VehiclePrice / 100) - (5 * VehiclePrice / 100);
            }

            if (WeekendRabat)
            {
                return VehiclePrice - (20 * VehiclePrice / 100);
            }

            return VehiclePrice;
        }

        public Bil()
        {
            Dato = DateTime.Now.DayOfWeek;
            BrobizzBrugt = false;
            WeekendRabat = false;
            Øresundsbroen = false;
            
        }


    }
}
