using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace StarWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Person one = GetPerson(90);

            if (one == null)
            {
                Console.WriteLine("Error 404");
            }
           // ToXMLfile toXMLfile = new ToXMLfile(one);
            
            Console.ReadLine();
        }



        public static Person GetPerson (int personId)
        {
            string link = "https://swapi.co/api/people/"+personId;
            WebClient webClient = new WebClient();
            Person personRequest;
            string jsonFile;
            try {
                jsonFile = webClient.DownloadString(link);
                personRequest = JsonConvert.DeserializeObject<Person>(jsonFile);
                return personRequest;
            }
            catch
            {
                personRequest = null;
            }
            return personRequest;        
        }
    }
}
