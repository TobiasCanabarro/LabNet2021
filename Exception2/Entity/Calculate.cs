using System;
using System.Collections.Generic;
using System.Text;
using Exception2.Exceptions;
using Exception2.Validator;

namespace Exception2.Entity
{
    public class Calculate
    {

        public static float Division(string dividend, string divider)
        {
            CalculateValidator validator = new CalculateValidator();

            if (validator.isZero(divider))
            {
                throw new DivideByZeroException();
            }

            if (!validator.isValid(dividend, divider))
            {
                InvalidDataException.ThrowException();
            }        

            return Int32.Parse(dividend) / Int32.Parse(divider);
        }
    }
}
