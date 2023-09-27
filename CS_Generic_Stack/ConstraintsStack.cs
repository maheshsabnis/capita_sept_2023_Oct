﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Generic_Stack
{
    /// <summary>
    /// Define Constraints for T that it will always be a class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class ConstraintsStack<T> where T : class
    {
        // Generic Member
        T[] arr = new T[5];
        int top = 0;

        // Generic Method: Either input or output or both input and output parameters are generic
        // 

        public void Push(T item)
        {
            arr[top++] = item;
        }

        public T Pop() 
        {
            return arr[--top];
        }

        public T[] Show() 
        {
            return arr;
        }
    }
}
