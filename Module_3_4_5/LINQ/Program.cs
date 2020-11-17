using System;
using System.Collections.Generic;
using Bogus;
using System.Linq;

namespace LINQ
{
    class Dummy
    {
        public string First { get; set; }
        public string Last { get; set; }
    }

    class Program
    {
        static string OrderByLastName(Person person)
        {
            return person.LastName;
        }
        static string OrderByFirstName(Person person)
        {
            return person.FirstName;
        }
        static bool FilterByFirstnameStartingWithA(Person p)
        {
            return p.FirstName.StartsWith("A");
        }
        static bool FilterByFirstnameStartingWithB(Person p)
        {
            return p.FirstName.StartsWith("B");
        }
        static Dummy ProjectFirstAndLast(Person p)
        {
            return new Dummy { First = p.FirstName, Last = p.LastName };
        }
        static void Main(string[] args)
        {
            Faker<Person> faker = new Faker<Person>();
            faker.RuleFor(p => p.ID, f => f.IndexFaker);
            faker.RuleFor(p => p.FirstName, f => f.Name.FirstName());
            faker.RuleFor(p => p.LastName, f => f.Name.LastName());
            faker.RuleFor(p => p.Age, f => f.Random.Int(0, 123));
            List<Person> people = faker.Generate(1000);

            //string ck = Console.ReadLine();
            //var query = people.OrderBy(p=>p.FirstName);
            //var query = people.Where(p=>p.FirstName.StartsWith(ck));
            //var query = people.Select(p => new { p.FirstName, p.LastName });
            //foreach (var p in query)
            //{
            //    Console.WriteLine($"{p.FirstName} {p.LastName}");
            //}

            //var max = people.Sum(p => p.Age);
            //Console.WriteLine(max);

            var query = from p in people 
                        where p.Age > 50 
                        orderby p.LastName descending 
                        select p;

            var q2 = from p in people group p by p.Age into q select new { Key = q.Key, Vals = q };

            foreach(var qq in q2)
            {
                Console.WriteLine(qq.Key);
                foreach(var item in qq.Vals)
                {
                    Console.WriteLine($"\t{item.FirstName}");
                }
            }

            foreach (Person p in query)
            {
                //Console.WriteLine($"[{p.ID}] {p.FirstName} {p.LastName} ({p.Age})");
            }
        }
    }
}
