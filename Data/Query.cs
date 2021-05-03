using Data;
using System;
using System.Linq;

namespace EF.Logic
{
    public class Query
    {
        private readonly NorthwindContext db;

        public Query()
        {
            this.db = new NorthwindContext();
        }

        /* Desde aca Query Syntax*/

        /* 1. Query para devolver objeto customer */
        public void Query1()
        {
            var query = from cus in db.Customers
                        select new
                        {
                            ID = cus.CustomerID,
                            Name = cus.CompanyName,
                            Phone = cus.Phone
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"ID : {item.ID} - CompanyName{item.Name} - Phone : {item.Phone}");
            }
            
            Console.ReadLine();

        }

        /* 2. Query para devolver todos los productos sin stock */
        public void Query2()
        {
            var query = from prod in db.Products
                        where prod.UnitsInStock == 0
                        select new
                        {
                            ID = prod.ProductID,
                            Name = prod.ProductName,
                            UnitPrice = prod.UnitPrice
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"ID : {item.ID} - Product Name : {item.Name} - Price ${item.UnitPrice}");
            }
            Console.ReadLine();
        }

        /* 3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad */
        public void Query3()
        {
            var query = from prod in db.Products
                        where prod.UnitsInStock > 0 && prod.UnitPrice > 3
                        select new
                        {
                            ID = prod.ProductID,
                            Name = prod.ProductName,
                            UnitPrice = prod.UnitPrice
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"ID : {item.ID} - Product Name : {item.Name} - Price ${item.UnitPrice}");
            }
            Console.ReadLine();
        }

        /* 4. Query para devolver todos los customers de Washington */
        public void Query4()
        {
            var query = from cust in db.Customers
                        where cust.Region == "WA"
                        select new
                        {
                            ID = cust.CustomerID,
                            Name = cust.CompanyName,
                            Region = cust.Region
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"ID : {item.ID} - Company Name : {item.Name} - Region : {item.Region}");
            }
            Console.ReadLine();
        }

        /* 5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789*/
        public void Query5()
        {
            var query = from prod in db.Products
                        where prod.ProductID == 789
                        select new
                        {
                            ID = prod.ProductID,
                            Name = prod.ProductName,
                            UnitPrice = prod.UnitPrice
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"ID : {item.ID} - Product Name : {item.Name} - Unite Price : ${item.UnitPrice}");
            }
            Console.ReadLine();
        }

        /*  6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.*/
        public void Query6()
        {
            var query = from cust in db.Customers
                        select new { 
                            NameLower = cust.CompanyName.ToLower(),
                            NameUpper  = cust.CompanyName.ToUpper() 
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"Name Lower : {item.NameLower}");
                Console.WriteLine($"Name Upper : {item.NameUpper}");
            }
            Console.ReadLine();
        }


        /*7. Query para devolver Join entre Customers y Orders donde los customers sean de 
         *   Washington y la fecha de orden sea mayor a 1/1/1997. */
        public void Query7()
        {
            var query = from cust in db.Customers
                        join ord in db.Orders
                        on cust.Region equals ord.ShipCity
                        where cust.Region == "WA" && 
                        ord.OrderDate > new DateTime(1997, 1, 1)
                        select new {
                            Region = cust.Region, 
                            OrderDate = ord.OrderDate
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"Region : {item.Region} - Order date {item.OrderDate}");
                Console.ReadLine();
            }
        }

        /* 8. Query para devolver los primeros 3 Customers de Washington */
        public void Query8()
        {
            var query = db.Customers.Where(c => c.Region.Equals("WA"))
                                    .Take(3)
                                    .Select(c => c)
                                    .ToList();
  
            foreach (var item in query)
            {
                Console.WriteLine($"Company Name : {item.CompanyName} - Region : {item.Region}");
            }         
            Console.ReadLine();
        }

        /* 9. Query para devolver lista de productos ordenados por nombre */
        public void Query9()
        {
            var query = db.Products.OrderBy(p => p.ProductName)
                                    .Select(p => p.ProductName)
                                    .ToList();

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        /* 10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor. */
        public void Query10()
        {
            var query = db.Products.OrderByDescending(p => p.UnitsInStock)
                                    .Select(p => new 
                                    {
                                        ProductName = p.ProductName, 
                                        UnitsInStock = p.UnitsInStock
                                    }).ToList();

            foreach (var item in query)
            {
                Console.WriteLine($"Product name : {item.ProductName} - Units in stock : {item.UnitsInStock}");
            }
            Console.ReadLine();
        }

        /* 11. Query para devolver las distintas categorías asociadas a los productos */
        public void Query11()
        {

            var query = db.Products
                        .Join(db.Categories,
                        prod => prod.CategoryID,
                        catg => catg.CategoryID,
                        (prod, catg) => new
                        {
                            ProductName = prod.ProductName,
                            Category = catg.CategoryName
                        })
                        .ToList();

            foreach (var item in query)
            {
                Console.WriteLine($"Product name : {item.ProductName} - Category : {item.Category}");
            }
            Console.ReadLine();
        }

        /* 12. Query para devolver el primer elemento de una lista de productos (tiene que ser una lista ?)*/
        public void Query12()
        {
            var query = db.Products
                .Take(1)
                .ToList();

            foreach (var item in query)
            {
                Console.WriteLine($"Product name : {item.ProductName}");
            }

            Console.ReadLine();
        }

        /* 13. Query para devolver los customer con la cantidad de ordenes asociadas */

        public void Query13()
        {
            var query = db.Customers
                .Join(db.Orders,
                cust => cust.CustomerID,
                ord => ord.CustomerID,
                (cust, ord) => new
                {
                    Name = cust.CompanyName,
                    ID = ord.CustomerID
                })
                .GroupBy(group => new {
                    group.Name,
                    group.ID
                })
                .Select(a => new {
                    Name = a.Key.Name,
                    Quantity = a.Count()
                })
                .ToList();


            foreach (var item in query)
            {
                Console.WriteLine($"Name : {item.Name} - Quantity orders : {item.Quantity}");
            }
            Console.ReadLine();
        }
    }
}
