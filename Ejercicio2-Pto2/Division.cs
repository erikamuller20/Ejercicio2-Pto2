using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Pto2
{
    public class Division
    {
        public static int div(int a, int b)
        {
            return a / b;
        }


        public static int divisionCero(int a, int b)
        {
            if (b == null)
            {
                throw new DivideByZeroException("Solo Chuck Norris divide por cero!");
            }
            return a / b;
        }

    }


}
