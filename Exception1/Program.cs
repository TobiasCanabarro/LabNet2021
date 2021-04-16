using System;

namespace Exception1
{
    class Program
    {
        private static string _fail_state = "No se pudo realizar la operacion";
        private static string _ok_state = "Se pudo realizar la operacion";
        
        static void Main(string[] args)
        {

            string state = _ok_state;
            float result = 0;
            int divider = 0;
            int num = 10;

            try
            {
                result = num / divider;
            }
            catch (DivideByZeroException ex)
            {
                state = _fail_state;
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine($"{state}, el resultado es {result}!");
            }
                       
        }
    }
}
