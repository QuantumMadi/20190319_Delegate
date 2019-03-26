using System;
using StarWars.Services;
using StarWars.Services.Abstract;
using StarWars.Models;

namespace StarWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert index of request person");
            if (!int.TryParse(Console.ReadLine(), out int index)) { Console.WriteLine("You inserted invalid index!"); };

            IDownloader<Person> downloader = new PersonDownloader();
            var personRepository = new PersonRepository();

            var person = personRepository.GetT(index);
            if (person == null)
            {
                person = downloader.DownloadRawJsonData("https://swapi.co/api/people", index);
                if(person!=null)personRepository.Add(person);
            }

            if(person!=null) Console.WriteLine($"{person.Name}\n{person.Hair_color}");
            else { Console.WriteLine("ERROR: 404"); }
            Console.ReadLine();
        }   
    }
}
