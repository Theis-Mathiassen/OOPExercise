using System.Collections;

namespace _08
{
    class SortedList : IList<IComparable>
    {
        public IComparable this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(IComparable item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(IComparable item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(IComparable[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IComparable> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(IComparable item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, IComparable item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IComparable item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
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