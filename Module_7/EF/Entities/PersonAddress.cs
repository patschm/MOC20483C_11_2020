using System;
using System.Collections.Generic;
using System.Text;

namespace EF.Entities
{
    public class PersonAddress
    {
        public int PersonID { get; set; }
        public int AddressID { get; set; }

        public Person Person { get; set; }
        public Address Address { get; set; }
    }
}
