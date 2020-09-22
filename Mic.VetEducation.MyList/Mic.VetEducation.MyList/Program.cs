using System;

namespace Mic.VetEducation.MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            list.Add(5).Add(50).Add(35).Add(100).Add(100).Add(5);

            Enumerator ob = new Enumerator(list);
            int max = ob.list.value;
            while (ob.list.Next != null)
            {
                if (max < ob.list.Next.value)
                {
                    max = ob.list.Next.value;
                }

                ob.MoveNext();
            }

            Console.WriteLine($"Max = {max}");
        }
    }
}
