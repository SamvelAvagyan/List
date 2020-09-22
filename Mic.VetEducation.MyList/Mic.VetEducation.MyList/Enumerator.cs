using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Mic.VetEducation.MyList
{
    class Enumerator : IEnumerator
    {
        public MyList root;
        public object Current { get; private set; }

        public Enumerator(MyList r)
        {
            root = r;
        }
        public bool MoveNext()
        {
            if(root.Next == null)
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
