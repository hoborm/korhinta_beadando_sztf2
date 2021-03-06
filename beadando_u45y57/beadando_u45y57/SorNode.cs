﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando_u45y57
{
    internal class SorNode<T>
    {
        public SorNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public SorNode<T> Next
        { get; set; }
    }
}