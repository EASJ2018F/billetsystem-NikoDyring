using System;

namespace BilletLib
{
    public abstract class Vehicle
    {

        public abstract string Nummerplade { get; set; }
        public abstract DayOfWeek Dato { get; set; }
        public abstract bool BrobizzBrugt { get; set; }
        public abstract bool WeekendRabat { get; set; }
        public abstract bool Øresundsbroen { get; set; }
        public abstract int VehiclePrice { get; set; }
        public abstract string TypeAfKøretøj();
        public abstract int LængdeAfNummerplade();

        public int Pris()
        {
            if (TypeAfKøretøj() == "Bil")
            {
                VehiclePrice = 240;
            }
            else if (TypeAfKøretøj() == "MC")
            {
                VehiclePrice = 125;
            }
            else if (TypeAfKøretøj() == "Øresund Bil")
            {
                VehiclePrice = 410;
                Øresundsbroen = true;
            }
            else if (TypeAfKøretøj() == "Øresund MC")
            {
                VehiclePrice = 210;
                Øresundsbroen = true;
            }

            //if (Dato == DateTime.Now.DayOfWeek )
            switch (Dato)
            {
                case DayOfWeek.Friday:
                    WeekendRabat = true;
                    break;
                case DayOfWeek.Saturday:
                    WeekendRabat = true;
                    break;
                case DayOfWeek.Sunday:
                    WeekendRabat = true;
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

            if (WeekendRabat && BrobizzBrugt && !Øresundsbroen)
            {
                return VehiclePrice - (20 * VehiclePrice / 100) - (5 * VehiclePrice / 100);
            }

            if (Øresundsbroen)
            {
                return VehiclePrice;
            }

            if (BrobizzBrugt && !Øresundsbroen)
            {
                return VehiclePrice - (5 * VehiclePrice / 100);
            }

            if (WeekendRabat)
            {
                return VehiclePrice - (20 * VehiclePrice / 100);
            }
            return VehiclePrice;

        }





    }
}