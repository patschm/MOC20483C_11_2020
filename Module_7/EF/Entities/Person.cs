using System;
using System.Collections.Generic;
using System.Text;

namespace EF.Entities
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public ICollection<PersonAddress> Addresses { get; set; } = new HashSet<PersonAddress>();
    }
}
