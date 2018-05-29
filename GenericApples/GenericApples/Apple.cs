using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApples
{
    public class Apple : ICountable
    {
        public Apple (string variety)
        {
            Variety = variety;
        }
        public string Variety { get; }
        public int Count => 1;
    }
}
