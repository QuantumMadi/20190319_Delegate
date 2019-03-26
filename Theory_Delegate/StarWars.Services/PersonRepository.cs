using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using StarWars.Models;
using StarWars.Services.Abstract;

namespace StarWars.Services
{
    public class PersonRepository : IRepository<Person>
    {
        public void Add(Person newPerson)
        {
            var data = GetAll();
            data.Add(newPerson);
            var serializer = new XmlSerializer(typeof(List<Person>));
            using(var stream = File.Open("file.xml", FileMode.Open))
            {
                serializer.Serialize(stream, data);
            }
        }
        private static List<Person> GetAll()
        {
            var type = typeof(List<Person>);
            var serializer = new XmlSerializer(type);
            using (var stream = File.Open("file.xml", FileMode.OpenOrCreate))
            {
                if (stream.Length == 0) return new List<Person>();
                return serializer.Deserialize(stream) as List<Person>;
            }
        }

        public Person GetT(int index)
        {
            Person emptyPerson = null;          
            if(GetAll().Count != 0)
            {
                foreach (var person in GetAll())
                {
                    if (person.Id == index) return person;                 
                }
            }
            return emptyPerson;         
        }
    }
}
