using System;
using System.Collections.Generic;
using System.Text;

namespace JsonApp
{
    public class Person
    {
        public Person(string name, int age, string country, string state, string street)
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
