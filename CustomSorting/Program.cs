using System;
using System.Collections.Generic;

namespace CustomSorting
{
    public class Student
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public decimal Marks {get; set;}
        
        public Student(string name, int age, decimal marks)
        {
            Name=name;
            Age=age;
            Marks=marks;
        }
    }

    public class StudentComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            // 1️⃣ Sort by Highest Marks
            int marksCompare = y.Marks.CompareTo(x.Marks);
            if (marksCompare != 0)
                return marksCompare;

            // 2️⃣ If Marks equal → Youngest Age
            return x.Age.CompareTo(y.Age);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Alice", 22, 90),
                new Student("Bob", 20, 90),
                new Student("Charlie", 21, 85),
                new Student("David", 19, 95)
            };

            students.Sort(new StudentComparer());

            foreach (var s in students)
            {
                Console.WriteLine($"{s.Name} - Age: {s.Age}, Marks: {s.Marks}");
            }
        }
    }
}