namespace _02
{
    class OrFilter : PersonFilter
    {
        public PersonFilter filter1 { get; set; }
        public PersonFilter filter2 { get; set; }
        public OrFilter(PersonFilter filter1, PersonFilter filter2)
        {
            this.filter1 = filter1;
            this.filter2 = filter2;
        }

        public override bool FilterPredicate(Person person) => filter1.FilterPredicate(person) || filter2.FilterPredicate(person);


    }
}
