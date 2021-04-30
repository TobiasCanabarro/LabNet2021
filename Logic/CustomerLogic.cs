using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic 
{
    public class CustomerLogic : Context, BaseLogic <Customers>
    {

        public CustomerLogic() : base()
        {
            
        }

        public void Add(Customers customer)
        {
            try
            {
                _context.Customers.Add(customer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void Delete(int id)
        {
            try
            {
                Customers customer = _context.Customers.Find(id);

            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public Customers Get(int id)
        {
            Customers customers = null;

            try
            {
                customers = _context.Customers.Find(id);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return customers;
        }

        public List<Customers> GetAall()
        {
            List<Customers> customers = null;
            try
            {
                customers = _context.Customers.ToList();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return customers;
        }

        public void Update(Customers entity)
        {
            
        }
    }
}
