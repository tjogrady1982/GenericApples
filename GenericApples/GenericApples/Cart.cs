﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApples
{
    class Cart<T> : Box<Box<T>> where T : ICountable
    {

    }
}
