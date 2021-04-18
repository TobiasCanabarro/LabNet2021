using Exception3.Exception;
using System;
using System.Collections.Generic;
using System.Text;


namespace Exception3.Entity
{
    class Logic
    {
        private static readonly string _message = "Se produjo una excepcion, error al conectarse con la base de datos!";

        public bool ConnectionBD(string strConnection)
        {
            bool value = true;
            if (strConnection == null)
            {
                ThrowException();
            }
            return value;
        }

        private void ThrowException()
        {
            throw new ConnectionException(_message);
        }

    }
}
