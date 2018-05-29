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
        Func<T, bool> variety;
        //public delegate int Counter();

        public Counter(Func<T,bool> variety)
        {
            this.variety = variety;
        }

        public Counter() : this(variety => true)
        {
            //variety = Func<T,bool> false;
        }
        
        

        public void Add(T item)
        {
            if (variety(item))
            {
                count += item.Count;
            }


        }

        public int Count => count;


    }
}
