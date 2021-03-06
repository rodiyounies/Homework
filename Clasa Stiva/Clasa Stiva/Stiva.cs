﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Stiva
{
    public class Stiva<T>
    {
       
        private T[] data;
        private int count;
       
        public Stiva(int n)
        {
            data = new T[n];
            count = 0;
        }

        public bool Empty
            {
                get
                {
                    return count == 0;
                }
            }

            public void Push(T v)
            {
                if (count < data.Length)
                {
                    data[count++] = v;
                }
                else
                    throw new StackFullException("Stiva este plina");

            }

            public T Pop()
            {
                if (!this.Empty)
                {
                    count--;
                    return data[count];
                }
                else
                    throw new StackEmptyException("Stiva este goala");
            }
            public T Peek()
            {
                if (!this.Empty)
                {
                    return data[count - 1];
                }
                else
                    throw new StackEmptyException("Stiva este goala");
            }
        public void Clear()
        {
            data = new T[data.Length];
            count = 0;
        }

    }
}
