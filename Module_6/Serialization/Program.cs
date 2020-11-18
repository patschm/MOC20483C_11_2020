using Bogus;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        private static List<Person> people;

        static void Main(string[] args)
        {
            //PopulateList();
            //Serialize();
            //DeSerialize();
            //XmlSerialize();
            // XmlDeserialize();
            //JsonSerialize();
            JsonDeserialize();
        }

        private static void JsonDeserialize()
        {
            FileInfo fi = new FileInfo(@"E:\people.json");
            FileStream fs = fi.OpenRead();
            JsonSerializer ser = new JsonSerializer();
            ser.ContractResolver = new CamelCasePropertyNamesContractResolver();
            StreamReader rdr = new StreamReader(fs);
            List<Person> ps =  ser.Deserialize(rdr, typeof(List<Person>)) as List<Person>;

            foreach (Person p1 in ps)
            {
                Console.WriteLine($"{p1.FirstName} {p1.LastName}");
            }
        }

        private static void JsonSerialize()
        {
            FileInfo fi = new FileInfo(@"E:\people.json");
            FileStream fs = fi.Create();

            JsonSerializer ser = new JsonSerializer();
            ser.ContractResolver = new CamelCasePropertyNamesContractResolver();
            StreamWriter wrt = new StreamWriter(fs);
            ser.Serialize(wrt, people);

            wrt.Flush();
            fs.Close();


        }

        private static void XmlDeserialize()
        {
            FileInfo fi = new FileInfo(@"E:\people.xml");
            FileStream fs = fi.OpenRead();

            XmlSerializer ser = new XmlSerializer(typeof(List<Person>));
            List<Person> ps = ser.Deserialize(fs) as List<Person>;

            foreach (Person p1 in ps)
            {
                Console.WriteLine($"{p1.FirstName} {p1.LastName}");
            }
        }

        private static void XmlSerialize()
        {
            FileInfo fi = new FileInfo(@"E:\people.xml");
            FileStream fs = fi.Create();

            XmlSerializer ser = new XmlSerializer(typeof(List<Person>));
            ser.Serialize(fs, people);
            fs.Close();


        }

        private static void DeSerialize()
        {
            FileInfo fi = new FileInfo(@"E:\person.soap");
            FileStream fs = fi.OpenRead();
            SoapFormatter fmt = new SoapFormatter();
            List<Person> ps = fmt.Deserialize(fs) as List<Person>;

            foreach (Person p1 in ps)
            {
                Console.WriteLine($"{p1.FirstName} {p1.LastName}");
            }
        }

        private static void Serialize()
        {
            FileInfo fi = new FileInfo(@"E:\person.soap");
            FileStream fs = fi.Create();
           // Person p = people.FirstOrDefault();

            SoapFormatter fmt = new SoapFormatter();
            fmt.Serialize(fs, people);
            fs.Close();

        }

        static void PopulateList()
        {
            Faker<Person> faker = new Faker<Person>();
            faker.RuleFor(p => p.ID, f => f.IndexFaker);
            faker.RuleFor(p => p.FirstName, f => f.Name.FirstName());
            faker.RuleFor(p => p.LastName, f => f.Name.LastName());
            faker.RuleFor(p => p.Age, f => f.Random.Int(0, 123));
            people = faker.Generate(1000);

        }
    }
}
