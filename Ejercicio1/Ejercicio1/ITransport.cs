using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    public interface ITransport
    {
        string Stop();

        string Advance();

        int GetPassenger();

        void SetPassenger(int passenger);
    }
}
