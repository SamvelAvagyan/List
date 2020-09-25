using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Mic.VetEducation.MyList
{
    class MyList<T> : IEnumerable
    {
        public T value;
        public MyList<T> Next;

        public MyList<T> Add(T value)
        {
            Next = new MyList<T> { value = value };
            return Next;
        }

        public T Max()
        {
            T max = Next.value;
            MyList<T> _list = Next.Next;
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

        public T Min()
        {
            T min = Next.value;
            MyList<T> _list = Next.Next;
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
            return new Enumerator<T>(this);
        }

        private class Enumerator<A> : IEnumerator
        {
            public MyList<A> root;
            public object Current { get; private set; }

            public Enumerator(MyList<A> r)
            {
                root = r;
            }
            public bool MoveNext()
            {
                if (root.Next == null)
                {
                    return false;
                }

                Current = root.value;
                root = root.Next;
                return true;
            }

            public void Reset()
            {
                root.Next = null;
            }
        }
    }
}
