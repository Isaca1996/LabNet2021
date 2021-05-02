using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_Ejercicio_EF.Entitites;
using TP4_Ejercicio_EF.Logic;

namespace TP4_Ejercicio_EF
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomersLogic customersLogic = new CustomersLogic();
            ProductsLogic productsLogic = new ProductsLogic();
            OrdersLogic ordersLogic = new OrdersLogic();

            Console.WriteLine("Companias que tienen una C. \n");

            foreach (Customers customer in customersLogic.getAll().Where(c => c.CompanyName.Contains("C")))
            {
                Console.WriteLine($"{customer.CustomerID} - {customer.CompanyName} - {customer.ContactName} - {customer.ContactTitle}");
            }

            Console.WriteLine("\nLos 10 primeros orders. \n");

            foreach (Orders order in ordersLogic.getAll().Where(o => o.OrderID <= 10257))
            {
                Console.WriteLine($"{order.OrderID} - {order.ShipName} - {order.ShipCountry}");
            }

            Console.WriteLine("\nInsert a la tabla products. \n");

            productsLogic.insert(new Products 
            {
                ProductID = 78,
                ProductName = "Vodka"
            });

            foreach (Products product in productsLogic.getAll())
            {
                Console.WriteLine($"{product.ProductID} - {product.ProductName} - {product.UnitPrice}");
            }

            Console.WriteLine("\nUpdate a la tabla customers. \n");

            foreach (Customers customer in customersLogic.getAll().Where(c => c.CustomerID == "GODOS"))
            {
                Console.WriteLine($"{customer.CustomerID} - {customer.CompanyName} - {customer.ContactName} - {customer.ContactTitle}");
            }

            customersLogic.update(new Customers
            {
                CustomerID = "GODOS",
                ContactName = "Juan Hernandez",
                ContactTitle = "Owner"
            });

            foreach (Customers customer in customersLogic.getAll().Where(o => o.CustomerID == "GODOS"))
            {
                Console.WriteLine($"{customer.CustomerID} - {customer.CompanyName} - {customer.ContactName} - {customer.ContactTitle}");
            }

            Console.WriteLine("\nDelete a la tabla products. \n");

            productsLogic.delete(78);

            foreach (Products product in productsLogic.getAll())
            {
                Console.WriteLine($"{product.ProductID} - {product.ProductName}");
            }

            Console.ReadLine();


        }
    }
}
