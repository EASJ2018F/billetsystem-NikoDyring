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
        public override DateTime Dato { get; }

        public override int Pris()
        {
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
