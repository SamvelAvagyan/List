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
            this.value = value;
            Next = new MyList();
            return Next;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
