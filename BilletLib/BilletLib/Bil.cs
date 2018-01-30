using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public int Pris()
        {
            return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }
    }
}
