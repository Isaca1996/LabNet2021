using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_Ejercicio_EF.Entitites;

namespace TP4_Ejercicio_EF.Logic
{
    public class ProductsLogic : BaseLogic, IABMLogic<Products>
    {
        public void delete(int id)
        {
            var productAEliminar = context.Products.Find(id);

            context.Products.Remove(productAEliminar);

            context.SaveChanges();
        }

        public List<Products> getAll()
        {
            return context.Products.ToList(); 
        }

        public void insert(Products newProduct)
        {
            context.Products.Add(newProduct);

            context.SaveChanges();
        }

        public void update(Products product)
        {
            var productUpdate = context.Products.Find(product.ProductID);

            productUpdate.ProductName = product.ProductName;

            productUpdate.Discontinued = product.Discontinued;

            context.SaveChanges();
        }
    }
}
