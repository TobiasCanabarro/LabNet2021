using System;
using System.Collections.Generic;
using System.Text;

namespace Exception3.Exception
{
    public class ConnectionException : System.Exception
    {
        public ConnectionException (string message) : base(message)
        {

        }

        public void Feature()
        {
            Console.WriteLine($"Tipo de excepcion : {base.GetType().Name}");
            Console.WriteLine($"Mensaje : {base.Message}");
        }



    }
}
