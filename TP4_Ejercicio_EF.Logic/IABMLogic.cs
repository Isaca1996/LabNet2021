using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Ejercicio_EF.Logic
{
    interface IABMLogic<T>
    {

        List<T> getAll();

        void insert(T newEntity);

        void update(T entity);

        void delete(T entity);


    }
}
