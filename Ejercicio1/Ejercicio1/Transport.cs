using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    public abstract class Transport
    {
        private int passenger;

        public Transport(int passenger)
        {
            SetPassenger(passenger);
        }

        public abstract string Stop();
        public abstract string Advance();

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
