using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace VezbaLINQ
{
    public static class Test
    {
        public static List<int> list = new List<int> { 1, 6, 3, 72, 5, 45, 6 };
        public static List<Car> listOfCars = new List<Car>();
        public static void Sum()
        {
            int resultOfTheSum = list.Sum();
            Console.WriteLine("The sum is:" + resultOfTheSum);
        }

        public static void Average()
        {
            double resultOfTheAverage = list.Average();
            Console.WriteLine("The average number is:{0:0.00}", resultOfTheAverage);
        }

        public static void FindingCar()
        {
            Console.Write("Enter ID of the car:");
            Int32.TryParse(Console.ReadLine(),out int id);

            Car FindMyCar = listOfCars.Where(x => x.ID == id).FirstOrDefault();

            if (FindMyCar != null)
            {
                Console.WriteLine("My car is:" + FindMyCar.Name + " and he have id:" + FindMyCar.ID);
            }else
            {
                Console.WriteLine("That ID does not exits!");
            }
        }

        public static void LoadCars()
        {
            Car car1 = new Car {ID = 1,Name = "Golf 1"};
            Car car2 = new Car { ID = 2, Name = "Golf 2" };
            Car car3 = new Car { ID = 3, Name = "Golf 3" };
            Car car4 = new Car { ID = 4, Name = "Ford" };
            Car car5 = new Car { ID = 5, Name = "BMW" };
            Car car6 = new Car { ID = 6, Name = "Mercedes" };
            Car car7 = new Car { ID = 7, Name = "Fiat" };
            Car car8 = new Car { ID = 8, Name = "Yugo" };
            Car car9 = new Car { ID = 9, Name = "Dacia" };
            Car car10 = new Car { ID = 10, Name = "Opel" };

            listOfCars.Add(car1);
            listOfCars.Add(car2);
            listOfCars.Add(car3);
            listOfCars.Add(car4);
            listOfCars.Add(car5);
            listOfCars.Add(car6);
            listOfCars.Add(car7);
            listOfCars.Add(car8);
            listOfCars.Add(car9);
            listOfCars.Add(car10);
        }
    }
}
