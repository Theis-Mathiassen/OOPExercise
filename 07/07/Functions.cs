using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    delegate string StringJoin (string str1, string str2);
    delegate T Join<T> (T val1, T val2);

    delegate T Double<T>(T val1);

    internal class Functions
    {
        public string JoinThree (string str1, string str2, string str3, StringJoin joiner)
        {
            return joiner(joiner(str1, str2), str3);
        }

        public string JoinAll(StringJoin join, params string[] list)
        {
            string result = "";
            foreach (string val in list)
            {
                result = join(result, val);
            }
            return result;
        }

        public T JoinAll<T>(Join<T> join, T[] list)
        {
            T result = join(list[0], list[1]);
            for (int i = 2; i < list.Length; i++)
            {
                result = join(result, list[i]);
            }
            return result;
        }

        public bool Exists<T>(Predicate<T> f, T[] a)
        {
            foreach (T t in a)
            {
                if (f(t))
                {
                    return true;
                }
            }
            return false;
        }

        public T Twice<T>(Double<T> f, T v)
        {
            return f(f(v));
        }
    }
}
