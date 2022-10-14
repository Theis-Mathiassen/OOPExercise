using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class HandyMethods
    {
        static Random random = new Random();
        static internal T Max<T> (List<T> values) where T : IComparable<T>
        {
            T result = values[0];
            for (int i = 1; i < values.Count; i++)
            {
                if (values[i].CompareTo(result) > 0)
                {
                    result = values[i];
                }
            }
            return result;

        }
        static internal T Min<T>(List<T> values) where T : IComparable<T>
        {
            T result = values[0];
            for (int i = 1; i < values.Count; i++)
            {
                if (values[i].CompareTo(result) < 0)
                {
                    result = values[i];
                }
            }
            return result;

        }

        static internal void copy<T>(T[] source, T[] destination)
        {
            if (source.Length != destination.Length)
                throw new ArgumentException("Lengths does not match");

            for (int i = 0; i < source.Length; i++)
            {
                destination[i] = source[i];
            }
        }

        static internal void shuffle<T>(T[] array)
        {
            for (int n = 0; n < array.Length; n++)
            {
                int i = random.Next(n);
                int j = random.Next(n);
                (array[j], array[i]) = (array[i], array[j]);
            }
        }
    }
}
