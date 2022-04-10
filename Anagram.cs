using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class Anagram
    {
        public Boolean checkAnagram(string input1, string input2) {
            char[] array1 = input1.ToCharArray();
            char[] array2 = input2.ToCharArray();
            Array.Sort(array1);
            Array.Sort(array2);
            if(array1.SequenceEqual(array2))
                return true; 
            else
                return false;
        }
    }
}
