using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    public class Airplane : ITransport
    {
        private int passenger;

        public Airplane(int passenger)
        {
            SetPassenger(passenger);
        }

        public string Advance()
        {
            return $"El vehiculo esta avanzando con {GetPassenger()} personas!";
        }

        public string Stop()
        {
            return $"Tiene {GetPassenger()} pasajeros!"; ;
        }

        public int GetPassenger()
        {
            return this.passenger;
        }

        public void SetPassenger (int passenger)
        {
            this.passenger = passenger;
        }
    }
}
