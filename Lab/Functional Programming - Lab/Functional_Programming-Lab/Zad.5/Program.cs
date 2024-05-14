using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> students = new List<People>();
            int numOfPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfPeople; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                string name = input[0];
                int age = int.Parse(input[1]);
                People people = new People(name, age);
                students.Add(people);
            }
            string ageFilter = Console.ReadLine();
            int ageLimit = int.Parse(Console.ReadLine());
            Func<People, int, bool> filter=FilterGenerator(ageFilter);
            students = students.Where(student => filter(student, ageLimit)).ToList();
            string format = Console.ReadLine();
            Action<People> formatter = FormatterGenetartor(format);
            students.ForEach(student => formatter(student));
        }
        static Action<People> FormatterGenetartor(string format)
        {
            if (format=="name age")
            {
                return student => Console.WriteLine($"{student.Name} - {student.Age}");
            }
            if (format == "name")
            {
                return student => Console.WriteLine($"{student.Name}");
            }
            if (format == "age")
            {
                return student => Console.WriteLine($"{student.Age}");
            }
            return null;
        }

        static Func<People,int, bool> FilterGenerator (string ageFilter)
        {
            Func<People, int, bool> filter = null;
            if (ageFilter=="older")
            {
                filter = (student, age) => student.Age >= age;
            }
            if (ageFilter == "younger")
            {
                filter = (student, age) => student.Age < age;
            }
            return filter;
        }
    }
    public class People
    {
        public People(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
