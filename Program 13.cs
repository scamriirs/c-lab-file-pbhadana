using System;

class AdmissionEnquiry
{
    static void Main()
    {
        Console.WriteLine("===== Admission Enquiry Form =====");

        // Collecting user details
        Console.Write("Enter your Full Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your Email: ");
        string email = Console.ReadLine();

        Console.Write("Enter your Phone Number: ");
        string phone = Console.ReadLine();

        Console.Write("Enter your Preferred Course: ");
        string course = Console.ReadLine();

        Console.Write("Enter your City: ");
        string city = Console.ReadLine();

        // Displaying the collected details
        Console.WriteLine("\n===== Enquiry Details Submitted Successfully =====");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Phone: {phone}");
        Console.WriteLine($"Preferred Course: {course}");
        Console.WriteLine($"City: {city}");

        Console.WriteLine("\nThank you for your enquiry. Our team will contact you soon!");
    }
}
