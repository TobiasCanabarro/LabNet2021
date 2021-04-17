using Exception2.Entity;
using Exception2.Exceptions;
using System;

namespace Exception2
{
    public class Program
    {
        static void Main(string[] args)
        {
            float result = 0;
            string dividend;
            string divider;

            try
            {
                Console.WriteLine("Ingrese el dividendo :");
                dividend = Console.ReadLine();

                Console.WriteLine("Ingrese el divisor :");
                divider = Console.ReadLine();

                result = Calculate.Division(dividend, divider);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Solo Chuck Norris divide por cero!, {ex.Message}");
            }
            catch (InvalidDataException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine($"El resultado de la division es {result}!");
            }
        }
    }
}
