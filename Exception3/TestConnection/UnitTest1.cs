using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestConnection
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_connected_to_bd()
        {
            var logic = new Logic();
            bool result = false;
            try
            {
                result = logic.ConnectionBD("bd:192.123.239.1:2552");
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

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void Cant_connected_to_bd()
        {
            var logic = new Logic();
            bool result = false;
            try
            {
                result = logic.ConnectionBD("bd:192.123.239.1:2552");
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

            Assert.AreEqual(result, true);
        }
    }
}
