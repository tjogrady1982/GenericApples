using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApples
{
    public class Apple : ICountable
    {
        public string Variety { get; set; }
        public int Count => 1;
    }
}
