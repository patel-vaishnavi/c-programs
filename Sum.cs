using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class Sum
    {
        public int sumOfNnumbers(int number) {
            int i,sum=0;
            for (i = 1; i <= number; i++)
                sum += i;
            return sum;
        }
    }
}
