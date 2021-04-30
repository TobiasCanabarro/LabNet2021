using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Factory
{
    public class EmployeeFactory 
    {
        public static Employees Create(int employeeID, string lastName, string firstName, string title, string titleOfCourtesy,
            DateTime? birthDate, DateTime? hireDate, string address, string city, string region, string postalCode,
            string country, string homePhone, string extension, byte[] photo, string notes, int? reportsTo, string photoPath)
        {
            return new Employees(employeeID, lastName, firstName, title, titleOfCourtesy,
             birthDate, hireDate, address, city, region, postalCode, country, homePhone,  
             extension, photo, notes, reportsTo, photoPath);
        }
    }
}
