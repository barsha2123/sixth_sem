using System;

class Student
{
    // Auto-implemented properties
    public string Name { get; set; }
    public int Roll { get; set; }
    public double Marks { get; set; }

    // Constructor to initialize all properties
    public Student(string name, int roll, double marks)
    {
        Name = name;
        Roll = roll;
        Marks = marks;
    }

    // Method to display student details
    public void Display()
    {
        Console.WriteLine("Student Details:");
        Console.WriteLine("Name  : " + Name);
        Console.WriteLine("Roll  : " + Roll);
        Console.WriteLine("Marks : " + Marks);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Object creation using the constructor
        Student student1 = new Student("John", 101, 89.5);

        // Display student information
        student1.Display();

        Console.ReadLine();
    }
}