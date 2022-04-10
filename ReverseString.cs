using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class ReverseString
    {
        public String reverseString(string input)
        {
            int i, j;
            char[] array = input.ToCharArray();
            char temp;
            for (i = 0, j = (array.Length)-1; i < j; i++, j--)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            return new String(array);
        }
    }
}
