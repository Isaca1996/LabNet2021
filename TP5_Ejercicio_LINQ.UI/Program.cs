using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace TP5_Ejercicio_LINQ.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            var db = new NorthwindContext();

            //db.Database.Log = Console.WriteLine;

            Console.WriteLine("1. Query para devolver objeto customer.\n");

            var query = from customer in db.Customers
                        orderby customer.CompanyName ascending
                        select customer;

            foreach (var item in query)
            {
                Console.WriteLine($"{item.CustomerID} - {item.CompanyName} - {item.ContactName} - {item.ContactTitle}");
            }

            Console.WriteLine("\n2. Query para devolver todos los productos sin stock.\n");

            var query1 = db.Products.Where(p => p.UnitsInStock == 0)
                                    .OrderBy(p => p.ProductName)
                                    .ToList();

            foreach (var item in query1)
            {
                Console.WriteLine($"{item.ProductID} - {item.ProductName} - {item.QuantityPerUnit} - {item.UnitPrice} - {item.UnitsInStock}");
            }

            Console.WriteLine("\n3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad.\n");

            var query2 = from products in db.Products
                         where products.UnitsInStock != 0 && products.UnitPrice > 3
                         orderby products.UnitsInStock ascending
                         select products;

            foreach (var item in query2)
            {
                Console.WriteLine($"{item.ProductID} - {item.ProductName} - {item.QuantityPerUnit} - {item.UnitsInStock} - {item.UnitPrice}");
            }

            Console.WriteLine("\n4. Query para devolver todos los customers de Washington.\n");

            var query3 = db.Customers.Where(c => c.Region == "WA")
                                     .ToList();

            foreach (var item in query3)
            {
                Console.WriteLine($"{item.CustomerID} - {item.CompanyName} - {item.ContactName} - {item.ContactTitle} - {item.City} - {item.Region} ");
            }

            Console.WriteLine("\n 5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789\n");

            var query4 = db.Products.FirstOrDefault(p => p.ProductID == 789);

            if (query4 != null)
            {
                Console.WriteLine(query4.ProductID + " - " + query4.ProductName);
            } else
            {
                Console.WriteLine("Este producto no existe.");
            }

            Console.WriteLine("\n 6. Query para devolver los nombre de los Customers.\n");

            var query5 = from customer in db.Customers
                         select customer;

            foreach (var item in query5)
            {
                Console.WriteLine($"{item.ContactName}".ToUpper() + " - " + $"{item.ContactName}".ToLower());
            }

            Console.WriteLine("\n 7. Query para devolver Join entre Customers y Orders donde los customers sean de Washington y la fecha de orden sea mayor a 1 / 1 / 1997.\n");

            DateTime date = Convert.ToDateTime("1997/1/1");

            var query6 = from customer in db.Customers
                         join order in db.Orders
                            on customer.CustomerID equals order.CustomerID into joined
                         from j in joined.DefaultIfEmpty()
                         where j.Customers.Region == "WA" && j.OrderDate > date
                         orderby date
                         select j;

            foreach (var item in query6)
            {
                Console.WriteLine($"{item.Customers.ContactName} - {item.Customers.Region} - {item.OrderDate}");
            }


            Console.WriteLine("\n8. Query para devolver los primeros 3 Customers de Washington.\n");

            var query7 = db.Customers.Where(c => c.Region == "WA")
                                     .Take(3)
                                     .ToList();

            foreach (var item in query7)
            {
                Console.WriteLine($"{item.CustomerID} - {item.ContactName} - {item.Region}");
            }

            Console.WriteLine("\n9. Query para devolver lista de productos ordenados por nombre.\n");

            var query8 = from product in db.Products
                         orderby product.ProductName
                         select product;

            foreach (var item in query8)
            {
                Console.WriteLine($"{item.ProductID} - {item.ProductName} - {item.UnitPrice}");
            }

            Console.WriteLine("\n10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.\n");

            var query9 = db.Products.OrderByDescending(p => p.UnitsInStock)
                                    .ToList();

            foreach (var item in query9)
            {
                Console.WriteLine($"{item.ProductID} - {item.ProductName} - {item.UnitsInStock} - {item.UnitPrice}");
            }

            Console.WriteLine("\n11. Query para devolver las distintas categorías asociadas a los productos.\n");

            var query10 = from categorie in db.Categories
                          join product in db.Products
                            on categorie.CategoryID equals product.CategoryID into joined
                          from j in joined.DefaultIfEmpty()
                          select j;

            foreach (var item in query10)
            {
                Console.WriteLine($"{item.Categories.CategoryName} - {item.ProductID} - {item.ProductName}");
            }

            Console.WriteLine("\n12. Query para devolver el primer elemento de una lista de productos.\n");

            var query11 = db.Products.First(p => p.ProductID < 10);

            Console.WriteLine(query11.ProductID + " - " + query11.ProductName + " - " + query11.QuantityPerUnit + " - " + query11.UnitPrice);

            Console.WriteLine("\n13. Query para devolver los customer con la cantidad de ordenes asociadas.\n");

            var query12 = from order in db.Orders
                          join customer in db.Customers
                            on order.CustomerID equals customer.CustomerID
                          group new { order, customer } by customer.ContactName
                          into ordersByCustomer
                          select new
                          {
                              ContactName = ordersByCustomer.Key,
                              OrderID = ordersByCustomer.Count()
                          };


            foreach (var item in query12)
            {
                Console.WriteLine($"{item.ContactName} - {item.OrderID}");
            }


            Console.ReadLine();




        }


    }
}
