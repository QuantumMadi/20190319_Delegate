using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace StarWars
{
    public class ToXMLfile
    {
        private XmlDocument xmlDocument = new XmlDocument(); 

        public ToXMLfile(Person person)
        {         
           using (var fileStream = File.Open("Persons.xml", FileMode.OpenOrCreate))
            {
                xmlDocument.
            }
        }
    }
}