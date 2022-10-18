using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JsonApp
{
    public static class WorkWithFile
    {
        public static void Add(List<Person> person)
        {
            FileStream stream = File.Open("data.json", FileMode.OpenOrCreate);
          
            JsonSerializer js = new JsonSerializer();
           
            StreamWriter strWrit = new StreamWriter(stream);
            
            js.Serialize(strWrit, person);
            
            strWrit.Close();            
            stream.Close();
        }
        public static List<Person> Get()
        {
           // List<Person> listPerson = new List<Person>();
            FileStream stream = File.Open("data.json", FileMode.OpenOrCreate);
            
            JsonSerializer js = new JsonSerializer();
            
            StreamReader strRead = new StreamReader(stream);


             var person = (List<Person>)js.Deserialize(strRead, typeof(List<Person>));

           // listPerson.Add(person);
            strRead.Close();
            stream.Close();

            return person;
        }
        

    }
}
