using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exception
{
    public class MVCException : System.Exception
    {
        private static readonly string _message = "MVC Exception";

        public MVCException (string message) : base(message)
        {

        }
        public static MVCException ThrowException() => throw new MVCException(_message);

    }
}
