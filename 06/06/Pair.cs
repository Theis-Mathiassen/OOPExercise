using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Pair<T1, T2>
    {
        public T1 First { get; }
        public T2 Second { get; }
        public Pair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }
        internal Pair<T2, T1> Swap ()
        {
            return new Pair<T2, T1>(Second, First);
        }

        internal Pair<C,T2> setFst<C> (C setValue)
        {
            return new Pair<C, T2>(setValue, Second);
        }
        internal Pair<T1, C> setSnd<C>(C setValue)
        {
            return new Pair<T1, C>(First, setValue);
        }
        public override string ToString()
        {
            return "(" + First + "," + Second + ")";
        }
    }
}
