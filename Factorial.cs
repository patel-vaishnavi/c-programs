using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class Factorial
    {  
        public int factorialOf(int number) {
            int i,factorial=1;
            for (i = 2; i <= number; i++)
                factorial *= i;
            return factorial;
        }
    }
}
