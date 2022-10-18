using Newtonsoft.Json;
using System;
using System.IO;

namespace JsonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var human1 = new Person("Leo", 25, "BEL", "Brest", "Sovet");
            var human2 = new Person("Nick", 18, "UA", "Kiev", "Lenina");
            var human3 = new Person("Alex", 99, "Usa", "Cali", "25st");
            var numn4 = new Person("Alex", 99, "Usa", "Cali", "25st");
            WorkWithFile.Add(human1);
            WorkWithFile.Add(human2);
            Console.WriteLine(WorkWithFile.Get().Adress);
            var tableOne = new Table< string , int>();
            tableOne.Add(WorkWithFile.Get().Name, WorkWithFile.Get().Age, WorkWithFile.Get().Adress);
            tableOne.Print();
             
            //FileStream stream = File.Open("data.json", FileMode.OpenOrCreate);
            //JsonSerializer js = new JsonSerializer();
            //StreamWriter strWrit = new StreamWriter(stream);
            ////js.Serialize(strWrit,human1);
            ////js.Serialize(strWrit, human2);
            ////js.Serialize(strWrit, human3);
            //StreamReader strRead = new StreamReader(stream);
            //var person = (Person)js.Deserialize(strRead, typeof(Person));
            //Console.WriteLine(person.Adress);
            ////js.Deserialize<Person>(stream);
            //Console.WriteLine(strRead.ReadToEnd());
            //strWrit.Close();
            //stream.Close();

        }
    }
    

}
