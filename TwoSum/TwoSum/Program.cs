using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 2, 7, 11, 15 };
            int[] numbers = { 2,5,5,11 };
            int tar = 10;
            var result = TwoSum(numbers, tar);
            var str = string.Join(",", result);
            Console.WriteLine("Result: " + str);
            Console.ReadLine();

        }

        private static int[] TwoSum(int[] numbers, int tar)
        {
            var n = numbers.Length;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    Console.WriteLine("for loop inside(1) i: " + i);
                    Console.WriteLine("for loop(2) j: " + j);
                    Console.ReadLine();

                    Console.WriteLine("number 1: " + numbers[i]);
                    Console.WriteLine("number 2: " + numbers[j]);
                    Console.ReadLine();

                    var sum = numbers[i] + numbers[j];
                    Console.WriteLine("sum: " + sum);
                    Console.ReadLine();

                    if (sum == tar)
                    {
                        
                        int[] result = { i, j };
                        return result;
                    }
                }
            }


            return numbers;
        }
    }
}
