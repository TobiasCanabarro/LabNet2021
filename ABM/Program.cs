using Entities;
using Logic;
using Logic.Factory;
using System;

namespace ABM
{
    class Program
    {
        static void Main(string[] args)
        {
           InsertProd();
        }

        static void InsertProd()
        {
            Console.WriteLine("Insert prod!");
            Products product = ProductFactory.Create(79, "French Fries", 2, 1, "20 bags x 4 pieces", 55, 100, 0, 0 , false);
            ProductLogic logic = new ProductLogic();
            logic.Add(product);
        }

        static void UpdateProd()
        {
            Console.WriteLine("Update prod!");
            Products product = ProductFactory.Create(79, "French Fries", 2, 1, "20 bags x 4 pieces", 55, 0, 0, 0, true);
            ProductLogic logic = new ProductLogic();
            logic.Update(product);
        }

        static void DeleteProd()
        {
            Console.WriteLine("Delete prod!");
            Products product = ProductFactory.Create(79, "French Fries", 2, 1, "20 bags x 4 pieces", 55, 0, 0, 0, true);
            ProductLogic logic = new ProductLogic();
            logic.Delete(product.ProductID);
        }
    }
}
