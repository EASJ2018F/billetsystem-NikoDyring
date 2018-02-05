using System;

namespace BilletLib
{
    public class MC : Vehicle
    {

        public override string Nummerplade { get; set; }
        public override bool BrobizzBrugt { get; set; }
        public override bool Øresundsbroen { get; set; }
        public override int VehiclePrice { get; set; }

        /// <summary>
        /// Returnere typen af køretøj i form af en string, alt efter om Øresundsbroen er true.
        /// </summary>
        /// <returns></returns>

        public override string TypeAfKøretøj()
        {
            if (Øresundsbroen)
            {
                return "Øresund MC";
            }

            return "MC";
        }


        /// <summary>
        /// Returnere nummerpladen hvis længden af nummerpladen er mindre end 7, ellers kaster den en exception.
        /// </summary>
        /// <returns></returns>

        public override int LængdeAfNummerplade()
        {
            if (Nummerplade.Length > 7)
            {
                throw new ArgumentException("Nummerplade for lang.");
            }

            return Nummerplade.Length;
        }

        /// <summary>
        ///  Constructor, som sætter vores brobizz til at være false.
        /// </summary>

        public MC()
        {
            BrobizzBrugt = false;
        }
    }
}