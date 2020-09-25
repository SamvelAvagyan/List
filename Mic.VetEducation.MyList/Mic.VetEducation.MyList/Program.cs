using System;

namespace Mic.VetEducation.MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int> { value = 15 };
            list.Add(5).Add(50).Add(50).Add(100).Add(100).Add(5);
            Console.WriteLine($"Max = {Manager.Max<int>(list)} Min = {Manager.Min<int>(list)}");

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
