using Exception4.Entity;
using Exception4.Entity.Exception;
using System;

namespace Exception4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Logic.ThrowCustomException();
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Mensaje : {ex.Message}");
                Console.WriteLine($"Tipo de excepcion : {ex.GetType().Name}");
            }
        }
    }
}
