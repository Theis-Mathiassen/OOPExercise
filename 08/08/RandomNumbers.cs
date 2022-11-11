using System.Collections;

namespace _08
{
    class RandomNumbers : IEnumerable<int>
    {
        public int Seed { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public int Count { get; set; }

        public RandomNumbers(int seed, int max, int min, int count)
        {
            Seed = seed;
            Max = max;
            Min = min;
            Count = count;
        }

        class RandomNumbersEnumerator : IEnumerator<int>
        {
            Random r;
            public int Current { get; set; }
            public int Max { get; set; }
            public int Min { get; set; }
            public int Count { get; set; }

            object IEnumerator.Current => Current;

            public RandomNumbersEnumerator(int seed, int max, int min, int count)
            {
                r = new Random(seed);
                Max = max;
                Min = min;
                Count = count;
            }

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                Current = r.Next(Min, Max);
                return Count-- > 0;
            }

            public void Reset()
            {
                
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new RandomNumbersEnumerator(Seed, Max, Min, Count);
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