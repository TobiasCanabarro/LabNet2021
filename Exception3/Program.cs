using Exception3.Entity;
using Exception3.Exception;
using System;

namespace Exception3
{
    class Program
    {
        private static readonly string _str_connection = "bd:192.123.239.1:2552";

        static void Main(string[] args)
        {

            var logic = new Logic();
            bool result = false;

            try
            {
                result = logic.ConnectionBD(_str_connection);
            }
            catch (ConnectionException ex)
            {
                ex.Feature();
            }
            Console.WriteLine($"Coneccion = {result}");
        }
    }
}
