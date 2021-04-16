using System;

namespace Exception1
{
   public class Program
    {
        private static readonly string _fail_state = "No se pudo realizar la operacion";
        private static readonly string _ok_state = "Se pudo realizar la operacion";
        private static readonly int _divider = 0;
        private static readonly int _value = 10;
        
        static void Main(string[] args)
        {

            string state = _ok_state;
            float result = 0;
            int num = _value;

            try
            {
                result = num.Division(_divider);
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
