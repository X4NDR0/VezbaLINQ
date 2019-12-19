using System;

namespace VezbaLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Test.LoadCars();

            Console.WriteLine("Sum:");
            Console.WriteLine("=======================");
            Test.Sum();

            Console.WriteLine("Average:");
            Console.WriteLine("=======================");

            Test.Average();

            Console.WriteLine("Find car:");
            Console.WriteLine("=======================");

            Test.FindingCar();

            Console.ReadLine();
        }
    }
}
