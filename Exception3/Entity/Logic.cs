using System;
using System.Collections.Generic;
using System.Text;


namespace Exception3.Entity
{
    class Logic
    {

        public bool ConnectionBD(string strConnection)
        {
            bool value = true;
            if (strConnection == null)
            {
                throw new ArgumentNullException();
            }
            return value;
        }

    }
}
