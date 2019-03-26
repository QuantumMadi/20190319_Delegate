using Newtonsoft.Json;
using StarWars.Models;
using StarWars.Services.Abstract;
using System.Net;

namespace StarWars.Services
{
    public class PersonDownloader : IDownloader<Person>
    {
        public Person DownloadRawJsonData(string url, int id)
        {            
            Person newPerson;
            try
            {               
                using (var client = new WebClient())
                {                    
                    var stringFromLink = client.DownloadString(CheckString(url) + id);
                    newPerson = JsonConvert.DeserializeObject<Person>(stringFromLink);
                    newPerson.Id = id;
                }
            }
            catch
            {
                newPerson = null;
            }
            return newPerson;
        }
        private static string CheckString(string url)
        {
            if (url[url.Length-1] == '/') return url;
            else return $"{url}/";
        }
    }
}
