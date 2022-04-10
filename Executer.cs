using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Executer
    {
        public static void Main(String[] args) {
            Console.WriteLine(" your choices ");
            Console.WriteLine("1 for checking prime ");
            Console.WriteLine("2 for anagrams ");
            Console.WriteLine("3 for string reversing ");
            Console.WriteLine("4 for sum problem ");
            Console.WriteLine("5 for factorial ");
            Console.WriteLine("6 for sum of n numbers ");
            char output='y';
            int choice;
            while (output=='y') {
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Prime prime = new Prime();
                        Console.WriteLine("enter number");
                        int number = Convert.ToInt32(Console.ReadLine());
                        if (prime.isPrime(number))
                            Console.WriteLine(number + " is a prime number");
                        else
                            Console.WriteLine(number + " is not a prime number");
                        break;
                    case 2:
                        Anagram anagram = new Anagram();
                        Console.WriteLine("enter two strings");
                        string input1 = Console.ReadLine();
                        string input2 = Console.ReadLine();
                        if (anagram.checkAnagram(input1, input2))
                            Console.WriteLine(input1 + " and " + input2 + " are anagrams");
                        else
                            Console.WriteLine(input1 + " and " + input2 + " are not anagrams");
                        break;
                    case 3:
                        ReverseString reverseString = new ReverseString();
                        Console.WriteLine("enter string");
                        Console.WriteLine(reverseString.reverseString(Console.ReadLine()));
                        break;
                    case 4:
                        SumProblem sumProblem = new SumProblem();
                        Console.WriteLine("enter sum");
                        if (sumProblem.sumOfTwoArrayElements(new int[] { 9, 2, 0, 0, 5, 6, 7, 0 }, Convert.ToInt32(Console.ReadLine())))
                            Console.WriteLine("it contains the sum");
                        else
                            Console.WriteLine("it doesnt contain the sum");
                        break;
                    case 5:
                        Factorial factorial = new Factorial();
                        Console.WriteLine("enter number");
                        Console.WriteLine(factorial.factorialOf(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case 6:
                        Sum sum = new Sum();
                        Console.WriteLine("enter range");
                        Console.WriteLine(sum.sumOfNnumbers(Convert.ToInt32(Console.ReadLine())));
                        break;
                    default:
                        Console.WriteLine("wrong choice");
                        break;

                }
                Console.WriteLine("Y TO continue N  to stop ");
                output = Convert.ToChar(Console.ReadLine());
            }
        }

    }
}
