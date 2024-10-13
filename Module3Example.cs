using System;

namespace Module3Example.cs
{
    // Your code goes here
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    public class Student : Person
    {
        public string Major { get; set; }
        public double GPA { get; set; }

        public Student(string name, int age, string major, double gpa)
            : base(name, age)
        {
            Major = major;
            GPA = gpa;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Major: {Major}, GPA: {GPA}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Alice", 30);
            person.DisplayInfo();

            Student student = new Student("Bob", 20, "Computer Science", 3.8);
            student.DisplayInfo();

            Console.ReadLine();
        }
    }
}