using System;

namespace BilletLib
{
    public abstract class Vehicle
    {

        public abstract string Nummerplade { get; set; }
        public abstract DayOfWeek Dato { get; set; }
        public abstract bool BrobizzBrugt { get; set; }
        public abstract bool Øresundsbroen { get; set; }
        public abstract int VehiclePrice { get; set; }
        public abstract string TypeAfKøretøj();
        public abstract int LængdeAfNummerplade();

        public int Pris()
        {

            switch (TypeAfKøretøj())
            {
                case "Bil":
                    VehiclePrice = 240;
                    break;
                case "MC":
                    VehiclePrice = 125;
                    break;
                case "Øresund Bil":
                    VehiclePrice = 410;
                    break;
                case "Øresund MC":
                    VehiclePrice = 210;
                    break;
            }


            if (BrobizzBrugt && Øresundsbroen)
            {
                if (TypeAfKøretøj() == "Øresund MC")
                {
                    VehiclePrice = 73;
                }
                else if (TypeAfKøretøj() == "Øresund Bil")
                {
                    VehiclePrice = 161;
                }
                return VehiclePrice;
            }

            if (Øresundsbroen)
            {
                return VehiclePrice;
            }

            if (BrobizzBrugt && !Øresundsbroen)
            {
                return VehiclePrice - (5 * VehiclePrice / 100);
            }
            return VehiclePrice;

        }





    }
}