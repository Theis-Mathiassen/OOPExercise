using System.Collections;

namespace _08
{
    public delegate int Skip(int prev, int current);
    class Sequence : IEnumerable<int>
    {
        public Skip skip { get; set; }
        public int Start { get; set; }
        public Sequence(Skip skip, int start)
        {
            this.skip = skip;
            Start = start;
        }
        class SequenceEnumerator : IEnumerator<int>
        {
            public int Current { get; private set; } = -1;
            public int Count { get; private set; }
            public int Prev { get; set; } = 0;
            Skip skip;

            public SequenceEnumerator(int current, int count, Skip skip)
            {
                Current = current;
                Count = count;
                this.skip = skip;
            }

            object IEnumerator.Current => Current;

            public void Dispose()
            {

            }

            public bool MoveNext()
            {
                (Prev, Current) = (Current, skip(Prev, Current));
                

                if (Count-- > 0)
                    return true;
                return false;
            }

            public void Reset()
            {

            }
        }
        public IEnumerator<int> GetEnumerator()
        {
            return new SequenceEnumerator(Start, 15, skip);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}






/* Smart
 * 
 * int current = -1;
            while (true)
            {
                yield return current;
            }

*/