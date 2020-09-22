using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Mic.VetEducation.MyList
{
    class Enumerator : IEnumerator
    {
        public MyList list;
        public object Current { get; private set; }

        public Enumerator(MyList l)
        {
            list = l;
        }
        public bool MoveNext()
        {
            if(list.Next == null)
            {
                return false;
            }

            Current = list.value;
            return true;
        }

        public void Reset()
        {
            list.Next = null;
        }
    }
}
