using System;
using System.IO;

class MetricConverter
{
    public static void ConvertAndSave()
    {
        string inputPath = "meters.txt";
        string outputPath = "feet.txt";

        if (File.Exists(inputPath))
        {
            string[] lines = File.ReadAllLines(inputPath);
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    double meters = double.Parse(values[0]);
                    double cm = double.Parse(values[1]);

                    // Conversion
                    double totalCm = (meters * 100) + cm;
                    double inches = totalCm / 2.54;
                    double feet = Math.Floor(inches / 12);
                    inches %= 12;

                    writer.WriteLine($"{meters}m {cm}cm = {feet}ft {inches:F2}in");
                }
            }
            Console.WriteLine("Conversion completed. Check feet.txt.");
        }
        else
        {
            Console.WriteLine("meters.txt not found.");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter meter and cm values (e.g., 1,50): ");
        string input = Console.ReadLine();
        File.WriteAllText("meters.txt", input);

        MetricConverter.ConvertAndSave();
    }
}
