using System;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Course { get; set; }

    public void StudentRecord()
    {
        Console.WriteLine($"Student Name: {Name}, Age: {Age}, Course: {Course}");
    }
}

// Delegate declaration
delegate void StudentDelegate();

class Program
{
    static void Main()
    {
        Student student = new Student { Name = "John", Age = 20, Course = "Computer Science" };

        // Assign method to delegate
        StudentDelegate studentDelegate = student.StudentRecord;
        studentDelegate(); // Invoke the delegate
    }
}
