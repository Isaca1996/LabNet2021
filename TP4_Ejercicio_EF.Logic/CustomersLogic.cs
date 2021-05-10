using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_Ejercicio_EF.Entitites;

namespace TP4_Ejercicio_EF.Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic<Customers>
    {
        public void delete(Customers customer)
        {
            var customerAEliminar = context.Customers.Find(customer.CustomerID);

            context.Customers.Remove(customerAEliminar);

            context.SaveChanges();
        }

        public List<Customers> getAll()
        {
            return context.Customers.ToList();
        }

        public void insert(Customers newCustomer)
        {
            context.Customers.Add(newCustomer);

            context.SaveChanges();
        }

        public void update(Customers customer)
        {
            var customerUpdate = context.Customers.Find(customer.CustomerID);

            customerUpdate.ContactName = customer.ContactName;
            customerUpdate.ContactTitle = customer.ContactTitle;
            customerUpdate.CompanyName = customer.CompanyName;
            customerUpdate.Phone = customer.Phone;

            context.SaveChanges();
        }
    }
}
