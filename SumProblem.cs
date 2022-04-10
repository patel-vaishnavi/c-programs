using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class SumProblem
    {
        public Boolean sumOfTwoArrayElements(int[] input,int sum)
        {
            int i,j,length;
            length = input.Length;
            for (i = 0; i <length ; i++) {
                for (j=i+1;j<length;j++) {
                    if (input[i] + input[j] == sum)
                        return true;
                }
            }
            return false;
        }
    }
}
