using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    public class Airplane : Transport
    {
        public Airplane(int passenger) : base(passenger)
        {
        }

        public override string Advance()
        {
            return $"El vehiculo esta avanzando con {GetPassenger()} personas!";
        }

        public override string Stop()
        {
            return $"Tiene {GetPassenger()} pasajeros!"; ;
        }

    }
}
