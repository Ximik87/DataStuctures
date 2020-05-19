﻿using System;

namespace DataStructures.Interfaces
{
    interface IStack<T>
    {
        int Count { get; }
        void Push(T item);      
        T Pop();
        T Peek();
    }
}
