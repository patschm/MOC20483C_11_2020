using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    [XmlRoot("person")]
    public class Person
    {
        [XmlAttribute("id")]
        public int ID { get; set; }
        [XmlElement("first-name")]
        public string FirstName { get; set; }
        [XmlElement("last-name")]
        public string LastName { get; set; }
        [XmlElement("age")]
        public int Age { get; set; }
    }
}
