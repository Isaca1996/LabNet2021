using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4_Ejercicio_EF.Data;

namespace TP4_Ejercicio_EF.Logic
{
    public class BaseLogic
    {

        protected readonly NorthwindContext context; 

        public BaseLogic()
        {
            context = new NorthwindContext();
        }

    }
}
