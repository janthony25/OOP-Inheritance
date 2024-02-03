using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // inheritance = 1 or more child classes receiving fields, methods ,etc. from a common parent

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            // Car
            Console.WriteLine(car.speed);
            Console.WriteLine($"Car has {car.wheels} wheels");
            car.go();
            Console.WriteLine();

            // Bicycle
            Console.WriteLine(bicycle.speed);
            Console.WriteLine($"Bicycle has {bicycle.wheels} wheels");
            bicycle.go();
            Console.WriteLine();

            // Boat
            Console.WriteLine(boat.speed);
            Console.WriteLine($"Boat has {boat.wheels} wheels");
            boat.go();

            

            Console.ReadKey();
        }
    }

    class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("The vehicle is moving!");
        }
    }

    class Car : Vehicle
    {
        public int wheels = 4;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}