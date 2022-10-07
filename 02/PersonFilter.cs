using System;
using System.Collections.Generic;

namespace _02
{
    abstract class PersonFilter
    {
        public virtual List<Person> Filter(List<Person> plist)
        {
            List<Person> filteredList = new List<Person>();

            foreach (Person p in plist)
            {
                if (FilterPredicate(p)) {
                    filteredList.Add(p);
                }
            }

            return filteredList;
        }
        public virtual List<Person> NotFilter(List<Person> plist)
        {
            List<Person> filteredList = new List<Person>();

            foreach (Person p in plist)
            {
                if (!FilterPredicate(p))
                {
                    filteredList.Add(p);
                }
            }

            return filteredList;
        }

        public abstract bool FilterPredicate(Person person);

    }
}
