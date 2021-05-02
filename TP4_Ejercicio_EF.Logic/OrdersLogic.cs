using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_Ejercicio_EF.Entitites;

namespace TP4_Ejercicio_EF.Logic
{
    public class OrdersLogic : BaseLogic, IABMLogic<Orders>
    {
        public void delete(int id)
        {
            var ordersAEliminar = context.Orders.Find(id);

            context.Orders.Remove(ordersAEliminar);

            context.SaveChanges();
        }

        public List<Orders> getAll()
        {
            return context.Orders.ToList();
        }

        public void insert(Orders newOrder)
        {
            context.Orders.Add(newOrder);

            context.SaveChanges();
        }

        public void update(Orders order)
        {
            var orderUpdate = context.Orders.Find(order.OrderID);

            orderUpdate.ShipAddress = order.ShipAddress;

            context.SaveChanges();
        }
    }
}
