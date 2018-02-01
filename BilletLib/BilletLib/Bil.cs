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
        public override DateTime Dato { get; set; }
        public override bool BrobizzBrugt { get; set; }
        public override bool WeekendRabat { get; set; }

        public override int Pris()
        {
            DayOfWeek dagenIDag = DateTime.Now.DayOfWeek;

            if ((dagenIDag == DayOfWeek.Friday) || (dagenIDag == DayOfWeek.Saturday) || (dagenIDag == DayOfWeek.Sunday))
            {
                WeekendRabat = true;
            }

            if (WeekendRabat && BrobizzBrugt)
            {
                return 240 - (5 * 240 / 100) - (20 * 240 / 100);
            }

            if (BrobizzBrugt)
            {
                return 240 - (5 * 240 / 100);
            }
            else if(WeekendRabat)
            {
                return 240 - (20 * 240 / 100);
            }
            return 240;
        }

        public override string TypeAfKøretøj()
        {
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
