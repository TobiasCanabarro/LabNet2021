using System;
using System.Collections.Generic;
using System.Text;

namespace Exception2.Exceptions
{
    public class InvalidDataException : Exception
    {
        private static string _messege = "Seguro Ingreso una letra o no ingreso nada!";

        public InvalidDataException()
        {
        }

        public InvalidDataException (string message) : base (message)
        {

        }

        public static void ThrowException()
        {
            throw new InvalidDataException(_messege);
        }
    }
}
