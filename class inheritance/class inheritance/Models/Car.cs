
namespace class_inheritance.Models
{
    internal class Car:Vehicle
    {
        public string Brand;
        public string Model;
        public int FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;

        public Car(string brand, string model, int fuelCapacity, double fuelFor1Km, double currentFuel,string color,int year)
        {
            Brand = brand;
            Model = model;
            FuelCapacity = fuelCapacity;
            FuelFor1Km = fuelFor1Km;
            CurrentFuel = currentFuel;
            Color = color;
            Year = year;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"FuelCapacity: {FuelCapacity}");
            Console.WriteLine($"FuelFor1Km: {FuelFor1Km}");
            Console.WriteLine($"CurrentFuel{CurrentFuel}");
            Console.WriteLine($"Color:{Color}");
            Console.WriteLine($"Year:{Year}");

        }

        public void Drive(int distance)
        {
            if (distance * FuelFor1Km <= CurrentFuel)
                Console.WriteLine("Qalan yanacagin miqdari: " + (CurrentFuel - distance * FuelFor1Km));
            else
                Console.WriteLine("Kifayet qeder yanacaq yoxdur");


        }
    }
}
