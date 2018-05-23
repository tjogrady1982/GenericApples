using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApples
{
    public class Counter<T>
    {
        public List<T> CountList = new List<T>();
        

        public int Count(T Item)
        {
            return CountList.Count;
        }

        public void Add(T item)
        {
            //var countList = new CountList();
            CountList.Add(item); 
        }

       
    }
}
