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

        public override int Pris()
        {
            Dato = DateTime.Now.DayOfWeek;

            if ((Dato == DayOfWeek.Friday) || (Dato == DayOfWeek.Saturday) || (Dato == DayOfWeek.Sunday) && !Øresundsbroen)
            {
                WeekendRabat = true;
            }


            if (BrobizzBrugt && Øresundsbroen)
            {
                return 161;
            }

            if (WeekendRabat && BrobizzBrugt && !Øresundsbroen)
            {
                return 240 - (5 * 240 / 100) - (20 * 240 / 100);
            }

            if(Øresundsbroen)
            {
                return 410;
            }

            if (BrobizzBrugt && !Øresundsbroen)
            {
                return 240 - (5 * 240 / 100);
            }
            else if (WeekendRabat)
            {
                return 240 - (20 * 240 / 100);
            }
            return 240;
        }

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
            if (Nummerplade.Length > 7)
            {
                throw new ArgumentException("Nummerplade for lang.");
            }

            return Nummerplade.Length;
        }


        public Bil()
        {

        }


    }
}
