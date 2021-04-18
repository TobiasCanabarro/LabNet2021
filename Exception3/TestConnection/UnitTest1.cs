using Exception3.Exception;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            catch (ConnectionException ex)
            {
                ex.Feature();
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
            catch (ConnectionException ex)
            {
                ex.Feature();
            }

            Assert.AreEqual(result, true);
        }
    }
}
