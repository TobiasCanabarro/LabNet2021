using Exception1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestCalculate
{
    [TestClass]
    public class TestCalculate
    {
        [TestMethod]
        public void Division_can_be_done()
        {
           int num = 10;
           Assert.AreEqual(2, num.Division(5));
        }

        [TestMethod]
        public void Division_cant_be_done()
        {
            bool state = true;
            float result = 0;
            int num = 10;
                        
            try
            {
                result = num.Division(0);
            }catch (DivideByZeroException)
            {
                state = false;
            }
            Assert.IsFalse(state);
        }
    }
}
