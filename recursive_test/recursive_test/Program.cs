using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace recursive_test
{
    class Program
    {
        public static Random random = new Random();
        public static int[] data = new int[100];
        public static int numberToFind = random.Next(100);
        public static int number = data.Length;
        public static bool number1;

        static void Main(string[] args)
        {
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(100);
            }

            Console.WriteLine("Number to find is: " + numberToFind);

            number1 = search(numberToFind, number);

            Console.ReadLine();
        }

        public static Boolean search(int var, int n)
        {
            if (n == 0)
            {
                Console.WriteLine("Number not found");
                return false;
            }
            if (data[n - 1] == var)
            {
                Console.WriteLine(data[n-1]);
                return true;
            }
            return search(var, n - 1);
        }
    }
}
