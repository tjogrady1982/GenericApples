using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApples
{
    public class Counter<T> where T : ICountable
    {
        private int count;

        public void Add(T item)
        {
            count += item.Count;
        }

        public int Count => count;


    }
}
