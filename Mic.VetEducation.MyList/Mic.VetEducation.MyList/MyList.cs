using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Mic.VetEducation.MyList
{
    class MyList : IEnumerable
    {
        public int value;
        public MyList Next;

        public MyList Add(int value)
        {
            Next = new MyList { value = value };
            return Next;
        }

        public int Max()
        {
            int max = Next.value;
            MyList _list = Next.Next;
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

        public int Min()
        {
            int min = Next.value;
            MyList _list = Next.Next;
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

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
