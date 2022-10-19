using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JsonApp
{
    public static class WorkWithFile
    {
        public static string Path()
        {
            Console.WriteLine("Enter Path");
            string path = Console.ReadLine();
            return path;
        }
        public static Person AddFromConsole()
        {
            
            Person pers = new Person();
            
            Console.Write("Name - ");
            pers.Name = Console.ReadLine();
            
            Console.Write("Age - ");
            pers.Age = Convert.ToInt32( Console.ReadLine());
            
            Console.Write("Country - ");
            pers.Adress.Country = Console.ReadLine();
            
            Console.Write("State - ");
            pers.Adress.State = Console.ReadLine();

            Console.Write("Street - ");
            pers.Adress.Street = Console.ReadLine();                     
            
            return pers;

        }
        public static void Add(List<Person> person)
        {
            FileStream stream = File.Open(Path(), FileMode.OpenOrCreate);
          
            JsonSerializer js = new JsonSerializer();
           
            StreamWriter strWrit = new StreamWriter(stream);
            
            js.Serialize(strWrit, person);
            
            strWrit.Close();            
            stream.Close();
        }
        public static List<Person> Get()
        {
            
            FileStream stream = File.Open(Path(), FileMode.OpenOrCreate);
            
            JsonSerializer js = new JsonSerializer();
            
            StreamReader strRead = new StreamReader(stream);


             var person = (List<Person>)js.Deserialize(strRead, typeof(List<Person>));

           
            strRead.Close();
            stream.Close();

            return person;
        }
        

    }
}
