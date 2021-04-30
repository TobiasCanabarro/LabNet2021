using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class AMBLogic<T>
    {
        private NorthwindContext northwindContext;

        protected AMBLogic()
        {
            northwindContext = new NorthwindContext();
        }

        public abstract void Add(T entity);

        public abstract void Update(T entity);

        public abstract T Get(int id);

        public abstract List<T> GetAall();

        public abstract void Delete(int id);

        public NorthwindContext GetNorthwindContext()
        {
            return this.northwindContext;
        }
    }
}
