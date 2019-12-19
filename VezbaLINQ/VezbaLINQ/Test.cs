using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace VezbaLINQ
{
    public static class Test
    {
        public static List<int> list = new List<int> { 1, 6, 3, 72, 5, 45, 6 };
        public static void Sum()
        {
            int resultOfTheSum = list.Sum();
            Console.WriteLine("The sum is:" + resultOfTheSum);
        }

        public static void Average()
        {
            double resultOfTheAverage = list.Average();
            Console.WriteLine("The average number is:{0:0.00}",resultOfTheAverage);
        }
    }
}
