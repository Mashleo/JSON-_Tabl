using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JsonApp
{
    public static class WorkWithFile
    {
        public static void Add(Person person)
        {
            FileStream stream = File.Open("data2.json", FileMode.OpenOrCreate);
          
            JsonSerializer js = new JsonSerializer();
           
            StreamWriter strWrit = new StreamWriter(stream);
            
            js.Serialize(strWrit, person);
            
            strWrit.Close();            
            stream.Close();
        }
        public static List<Person> Get()
        {
            List<Person> listPerson = new List<Person>();
            FileStream stream = File.Open("data.json", FileMode.OpenOrCreate);
            
            JsonSerializer js = new JsonSerializer();
            
            StreamReader strRead = new StreamReader(stream);


             var person = (Person)js.Deserialize(strRead, typeof(Person));

            listPerson.Add(person);
            strRead.Close();
            stream.Close();

            return listPerson;
        }
        public static Person[] Get(int a)
        {
            //var[] listPerson = new Person[;
            FileStream stream = File.Open("data.json", FileMode.OpenOrCreate);

            JsonSerializer js = new JsonSerializer();

            StreamReader strRead = new StreamReader(stream);


            Person[] listPerson = (Person[])js.Deserialize(strRead, typeof(Person));

            //listPerson.Add(person);
            strRead.Close();
            stream.Close();

            return listPerson;
        }

    }
}
