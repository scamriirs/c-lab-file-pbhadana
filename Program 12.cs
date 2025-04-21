using System;

class Car
{
    // Data members (Fields)
    public string brand;
    public string model;
    public int year;

    // Constructor (same name as class)
    public Car(string b, string m, int y)
    {
        brand = b;
        model = m;
        year = y;
    }

    // Method to display car details
    public void DisplayCarInfo()
    {
        Console.WriteLine($"Car Brand: {brand}");
        Console.WriteLine($"Car Model: {model}");
        Console.WriteLine($"Manufacturing Year: {year}");
    }
}

class Program
{
    static void Main()
    {
        // Creating objects of the Car class using constructor
        Car car1 = new Car("Toyota", "Corolla", 2022);
        Car car2 = new Car("Honda", "Civic", 2023);

        // Displaying car details
        Console.WriteLine("Car 1 Details:");
        car1.DisplayCarInfo();

        Console.WriteLine("\nCar 2 Details:");
        car2.DisplayCarInfo();
    }
}
