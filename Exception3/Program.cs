using Exception3.Entity;
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
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Mensaje : {ex.Message}");
                Console.WriteLine($"Tipo de excepcion : {ex.GetType().Name}");
            }
            finally
            {
                Console.WriteLine($"Coneccion = {result}");
            }
        }
    }
}
