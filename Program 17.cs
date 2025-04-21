using System;
using System.Collections.Generic;

class StudentRecords
{
    private Dictionary<string, string> studentData = new Dictionary<string, string>();
    private List<string> studentNames = new List<string>();

    // Indexer with integer index
    public string this[int index]
    {
        get { return studentNames[index]; }
        set { studentNames[index] = value; }
    }

    // Indexer with string key
    public string this[string name]
    {
        get { return studentData.ContainsKey(name) ? studentData[name] : "Not Found"; }
        set { studentData[name] = value; }
    }

    public void AddStudent(string name, string grade)
    {
        studentNames.Add(name);
        studentData[name] = grade;
    }
}

class Program
{
    static void Main()
    {
        StudentRecords records = new StudentRecords();
        records.AddStudent("John", "A");
        records.AddStudent("Alice", "B");

        Console.WriteLine("Student at index 0: " + records[0]); // Access using int index
        Console.WriteLine("Alice's Grade: " + records["Alice"]); // Access using string key

        records["Alice"] = "A+";
        Console.WriteLine("Alice's updated Grade: " + records["Alice"]);
    }
}
