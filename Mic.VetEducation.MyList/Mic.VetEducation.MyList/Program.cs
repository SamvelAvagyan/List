﻿using System;

namespace Mic.VetEducation.MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList { value = 15 };
            list.Add(5).Add(50).Add(50).Add(100).Add(100).Add(5);
            Console.WriteLine($"Max = {list.Max()} Min = {list.Min()}");
        }
    }
}
