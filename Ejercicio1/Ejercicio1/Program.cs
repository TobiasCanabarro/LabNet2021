using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    class Program
    {
        private static int _vehicleTypeMax = 5;
        private static string _airplane = "Airplane";
        private static string _car = "Car";

        static void Main(string[] args)
        {
            List<ITransport> vehicles = new List<ITransport>();
            string vehicleType = _airplane;
            int j = 0;

            for (int i = 0; i < _vehicleTypeMax; i++)
            {
                vehicles.Add(new Airplane(i + 1));
            }

            for (int i = 0; i < _vehicleTypeMax; i++)
            {
                vehicles.Add(new Car(i + 1));
            }

            foreach (var item in vehicles)
            {
                if (j > _vehicleTypeMax - 1)
                {
                    vehicleType = _car;
                    j = 0;
                }
                Console.WriteLine($" {vehicleType} {j} : {item.GetPassenger()} pasajeros!");
                j++;
            }


            Console.ReadLine();
        }
    }
}
