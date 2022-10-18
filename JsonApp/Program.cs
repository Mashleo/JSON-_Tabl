using Newtonsoft.Json;
using System;
using System.IO;

namespace JsonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var human1 = new Person("Leo",25,"BEL","Brest","Sovet");
            var human2 = new Person("Nick", 18, "UA", "Kiev", "Lenina");
            var human3 = new Person("Alex", 99, "Usa", "Cali", "25st");

            FileStream stream = File.Open("data.json", FileMode.OpenOrCreate);
            JsonSerializer js = new JsonSerializer();
            StreamWriter strWrit = new StreamWriter(stream);
            js.Serialize(strWrit,human1);
            js.Serialize(strWrit, human2);
            js.Serialize(strWrit, human3);
            StreamReader strRead =new StreamReader(stream);
            Console.WriteLine(strRead.ReadToEnd());
            strWrit.Close();
            
            stream.Close();

        }
    }
    public class Person
    {
        public Person( string name, int age, string country, string state, string street)
        {
            Name = name;
            Age = age;
            Adress = new Adress
            {
                Country = country,
                State = state,
                Street = street
            };


        }
        public string Name { get; set; }
        public int Age { get; set; }
        public Adress Adress { get; set; }
    }
    public class Adress
    {
        public string Country { get; set; }
        public string State { get; set; }
        public string Street { get; set; }

    }

}
