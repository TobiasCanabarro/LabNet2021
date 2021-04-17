using System;
using System.Text;

namespace Exception2.Validator
{
    public class CalculateValidator
    {
        public bool isValid(string dividend, string divisor)
        {
            int valueDividend = 0;
            int valueDivisor = 0;
            bool state = true;
            try
            {
                valueDividend = Int32.Parse(dividend);
                valueDivisor = Int32.Parse(divisor);
                state = valueDividend > 0 && valueDivisor > 0;
            }
            catch (FormatException)
            {
                state = false;
            }

            return state;
        }

        public bool isZero (string str)
        {
            return Int32.Parse(str) == 0;
        }

    }
}
