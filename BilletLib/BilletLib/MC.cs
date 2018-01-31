using System;

namespace BilletLib
{
    public class MC : Vehicle
    {
        public override string Nummerplade { get; }
        public override DateTime Dato { get; }

        public override int Pris()
        {
            return 125;
        }

        public override string TypeAfKøretøj()
        {
            return "MC";
        }
    }
}