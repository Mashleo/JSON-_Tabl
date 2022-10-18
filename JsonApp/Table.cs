using System;
using System.Collections.Generic;
using System.Text;

namespace JsonApp
{
    public class Table
    {
        public void Print( List<Person> person)
        {

            for (int i = 0; i < person.Count; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"|NAME\t|AGE\t|ADRESS\t|");
                }
                Console.WriteLine($"|{person[i].Name}\t|{person[i].Age}\t|{person[i].Adress.Country} {person[i].Adress.State} {person[i].Adress.Street}\t|");
            }

        }
        public void Print(Person[] person)
        {

            for (int i = 0; i < person.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"|NAME\t|AGE\t|ADRESS\t|");
                }
                Console.WriteLine($"|{person[i].Name}\t|{person[i].Age}\t|{person[i].Adress.Country} {person[i].Adress.State} {person[i].Adress.Street}\t|");
            }

        }
    }
}
