using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    
    public class Context
    {
        protected readonly NorthwindContext _context;

        public Context()
        {
            _context = new NorthwindContext();
        }

    }
}
