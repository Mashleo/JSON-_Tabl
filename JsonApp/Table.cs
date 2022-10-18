using System;
using System.Collections.Generic;
using System.Text;

namespace JsonApp
{
    public class Table<T, U>
    {
        public Table()
        {
            tValue = new List<T>();
            uValue = new List<U>();
            zValue = new List<Adress>();


        }

        public List<T> tValue { get; set; }
        public List<U> uValue { get; set; }
        public List<Adress> zValue { get; set; }
        public void Add(T _tvalue, U _uvalue, Adress _zvalue)
        {
            tValue.Add(_tvalue);
            uValue.Add(_uvalue);
            zValue.Add(_zvalue);
        }
        public void Print()
        {

            for (int i = 0; i < tValue.Count; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"|NAME\t|AGE\t|ADRESS\t|");
                }
                Console.WriteLine($"|{tValue[i]}\t|{uValue[i]}\t|{zValue[i].Country} {zValue[i].State} {zValue[i].Street}\t|");
            }

        }
    }
}
