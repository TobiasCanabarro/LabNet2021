using Exception4.Entity.Exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exception4.Entity
{
    class Logic
    {
        private static readonly string _message = "Se genero una excepcion personalizada!";

        public static void ThrowCustomException()
        {
            throw new CustomException(_message);
        }

    }
}
