using System;

class Car
{
    // Data members (Fields)
    public string brand;
    public string model;
    public int year;

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
        // Creating an object of the Car class
        Car myCar = new Car();
        
        // Assigning values to object properties
        myCar.brand = "Toyota";
        myCar.model = "Corolla";
        myCar.year = 2022;

        // Calling the method to display car details
        myCar.DisplayCarInfo();
    }
}
