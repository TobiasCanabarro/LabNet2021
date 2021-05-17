using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class EmployeesLogic : AMBLogic<Employees>
    {

        public EmployeesLogic() : base() { 

        }
        public override void Add(Employees employee)
        {
            try
            {
                GetNorthwindContext().Employees.Add(employee);
                GetNorthwindContext().SaveChanges();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }


        public override void Delete(int id)
        {
            Employees employee = null;

            try
            {
                employee = GetNorthwindContext().Employees.Find(id);
                GetNorthwindContext().Employees.Remove(employee);
                GetNorthwindContext().SaveChanges();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public override Employees Get(int id)
        {
            Employees employee = null;

            try
            {
                employee = GetNorthwindContext().Employees.Find(id);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return employee;
        }


        public override List<Employees> GetAll()
        {
            List<Employees> employees = null;
            try
            {
                employees = GetNorthwindContext().Employees.ToList();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return employees;
        }

        public override void Update(Employees employee)
        {
            Employees updatedEmployee = null;

            try
            {
                updatedEmployee = GetNorthwindContext().Employees.Find(employee.EmployeeID);
                UpdateEntity(updatedEmployee, employee);
                GetNorthwindContext().SaveChanges();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        //Actualiza los datos viejos con los nuevos.
        private void UpdateEntity(Employees updatedEmployee, Employees employee)
        {
            updatedEmployee.Address = employee.Address;
            updatedEmployee.BirthDate = employee.BirthDate;
            updatedEmployee.City = employee.City;
            updatedEmployee.Country = employee.Country;
            updatedEmployee.EmployeeID = employee.EmployeeID;
            updatedEmployee.Employees1 = employee.Employees1;
            updatedEmployee.Employees2 = employee.Employees2;
            updatedEmployee.Extension = employee.Extension;
            updatedEmployee.FirstName = employee.FirstName;
            updatedEmployee.HireDate = employee.HireDate;
            updatedEmployee.HomePhone = employee.HomePhone;
            updatedEmployee.LastName = employee.LastName;
            updatedEmployee.Notes = employee.Notes;
            updatedEmployee.Orders = employee.Orders;
            updatedEmployee.PhotoPath = employee.PhotoPath;
            updatedEmployee.PostalCode = employee.PostalCode;
            updatedEmployee.Region = employee.Region;
            updatedEmployee.ReportsTo = employee.ReportsTo;
            updatedEmployee.Territories = employee.Territories;
            updatedEmployee.Title = employee.Title;
            updatedEmployee.TitleOfCourtesy = employee.TitleOfCourtesy;           
        }
    }
}
