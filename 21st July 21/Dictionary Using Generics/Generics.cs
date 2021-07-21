using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Using_Generics
{
    class Generics<T, T1>
    {
        Dictionary<T, T1> dict = new Dictionary<T, T1>();

        public void Add(T key, T1 value) => dict.Add(key, value);
        public void Remove(T key) => dict.Remove(key);
        public void sort()
        {
            var list = dict.Keys.ToList();
            list.Sort();
            foreach (var key in list)
            {
                
                Console.WriteLine($"ID :{key},Name : {dict[key]}\n");
            }
        }

        public void sort1()
        {
            var list = dict.Keys.ToList();
            list.Sort();
            foreach (var key in list)
            {
                Console.WriteLine($"Name :{key},ID : {dict[key]}\n");
            }
        }
    }
}

