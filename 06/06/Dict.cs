using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Dict<K, V> where K : IComparable<K>
    {
        public List<Pair<K, V>> Pairs { get; set; }

        public Dict()
        {
            Pairs = new List<Pair<K, V>>();
        }

        public V Get(K key)
        {
            foreach (Pair<K, V> pair in Pairs)
            {
                if (pair.First.CompareTo(key) == 0)
                    return pair.Second;
            }
            throw new MissingMemberException("Element does not exist");
        }
        public void Put(Pair<K, V> input)
        {
            for (int i = 0; i < Pairs.Count; i++)
            {
                if (Pairs[i].First.CompareTo(input.First) == 0)
                {
                    Pairs[i] = Pairs[i].setSnd(input.Second);
                    return;
                }
            }
            Pairs.Add(input);
            return;
        }

    }
}
