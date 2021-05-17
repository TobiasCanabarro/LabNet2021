using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Exception
{
    public class ProductsException : System.Exception
    {

        private static readonly string _msg = "ProductsException";

        public ProductsException(string msg) : base(msg)
        {
        }

        public static void ThrowException()
        {
            throw new ProductsException(_msg);
        }
    }
}
