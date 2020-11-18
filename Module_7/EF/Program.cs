using EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EF
{
    class Program
    {
        static string conStr = @"Server=.\sqlexpress;Database=peopleDB;Trusted_Connection=True;MultipleActiveResultSets=true;";
        static void Main(string[] args)
        {
            DbContextOptionsBuilder bld = new DbContextOptionsBuilder();
            bld.UseSqlServer(conStr, opt => { });

            PeopleContext ctx = new PeopleContext(bld.Options);
            //ctx.Database.EnsureCreated();

            //Person p = new Person { Age = 42, FirstName = "Jan", LastName = "Pieters" };
            //Address a1 = new Address { City = "Meppel", Street = "Blankenstein", Number = "420" };
            //PersonAddress pa = new PersonAddress { Address = a1, Person = p };
            //p.Addresses.Add(pa);
            //ctx.People.Add(p);
            //ctx.SaveChanges();

            //Person p = ctx.People.Where(px => px.ID == 1).FirstOrDefault();
            //p.FirstName = "Karel";
            //p.LastName = "Doorman";

            //Person p = ctx.People.Where(px => px.ID == 1).FirstOrDefault();
            //ctx.Remove(p);
            //ctx.SaveChanges();

            var query = ctx.People.Include(p=>p.Addresses).ThenInclude(pa=>pa.Address);

            foreach(Person p in query)
            {
                Console.WriteLine($"{p.FirstName} {p.LastName}");
                //ctx.Entry(p).Collection("Addresses").Load();
                foreach(PersonAddress pa in p.Addresses)
                {
                   // ctx.Entry(pa).Reference("Address").Load();
                    Console.WriteLine($"\t{pa.Address.Street} {pa.Address.City}");
                }
            }

            


            Console.WriteLine("OK");
        }
    }
}
