using System;
using System.Collections.Generic;

class Student
{
    public string RegistrationNumber { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Class { get; set; }
    public string ContactNumber { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        // Taking input for 10 students
        for (int i = 0; i < 10; i++)
        {
            Student s = new Student();
            Console.WriteLine($"Enter details for Student {i + 1}:");

            Console.Write("Registration Number: ");
            s.RegistrationNumber = Console.ReadLine();

            Console.Write("Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Age: ");
            s.Age = int.Parse(Console.ReadLine());

            Console.Write("Class: ");
            s.Class = Console.ReadLine();

            Console.Write("Contact Number: ");
            s.ContactNumber = Console.ReadLine();

            students.Add(s);
            Console.WriteLine();
        }

        // Display all student data
        Console.WriteLine("List of Students:");
        foreach (Student s in students)
        {
            Console.WriteLine($"RegNo: {s.RegistrationNumber}, Name: {s.Name}, Age: {s.Age}, Class: {s.Class}, Contact: {s.ContactNumber}");
        }
    }
}
