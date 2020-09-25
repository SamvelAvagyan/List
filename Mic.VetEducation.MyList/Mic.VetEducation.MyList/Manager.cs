using System;
using System.Collections.Generic;
using System.Text;

namespace Mic.VetEducation.MyList
{
    static class Manager
    {
        public static T Max<T>(MyList<T> ml)
        {
            T max = ml.Next.value;
            MyList<T> _list = ml.Next.Next;
            while (_list != null)
            {
                if (max < _list.value)
                {
                    max = _list.value;
                }

                _list = _list.Next;
            }

            return max;
        }

        public static T Min<T>(MyList<T> ml)
        {
            T min = ml.Next.value;
            MyList<T> _list = ml.Next.Next;
            while (_list != null)
            {
                if (min > _list.value)
                {
                    min = _list.value;
                }

                _list = _list.Next;
            }

            return min;
        }
    }
}
