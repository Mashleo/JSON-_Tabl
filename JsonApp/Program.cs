using Newtonsoft.Json;
using System;
using System.IO;

namespace JsonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var human1 = new Person("Leo", 25, "BEL", "Brest", "Sovet");
            //var human2 = new Person("Nick", 18, "UA", "Kiev", "Lenina");
            //var human3 = new Person("Alex", 99, "Usa", "Cali", "25st");
            //var numn4 = new Person("Alex", 99, "Usa", "Cali", "25st");
            //WorkWithFile.Add(human1);
            //WorkWithFile.Add(human2);
            
            var tableOne = new Table();
            
            tableOne.Print(WorkWithFile.Get());
             
            
        }
    }
    

}
