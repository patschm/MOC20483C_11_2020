using System;
using System.Collections.Generic;
using System.Text;

namespace EF.Entities
{
    public class Address
    {
        public int ID { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }

        public ICollection<PersonAddress> People { get; set; } = new HashSet<PersonAddress>();
    }
}
