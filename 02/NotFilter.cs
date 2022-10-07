using System.Collections.Generic;

namespace _02
{
    class NotFilter : PersonFilter
    {
        public PersonFilter filter { get; set; }
        public NotFilter(PersonFilter filter)
        {
            this.filter = filter;
        }

        public override bool FilterPredicate(Person person)
        {
            return !filter.FilterPredicate(person);
        }
    }

    

}
