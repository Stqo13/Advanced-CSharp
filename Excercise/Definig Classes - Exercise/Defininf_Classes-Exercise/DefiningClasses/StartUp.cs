
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family= new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] familyMembers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person();
                person.Name = familyMembers[0];
                person.Age = int.Parse(familyMembers[1]);
                if (person.Age > 30)
                {
                    family.AddMember(person);
                }
            }
            family.OrderMembers();
            foreach (var item in family.People)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}
