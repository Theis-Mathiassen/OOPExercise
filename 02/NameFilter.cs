namespace _02
{
    class NameFilter : PersonFilter
    {
        public string Name { get; set; }
        public NameFilter(string name)
        {
            Name = name;
        }

        public override bool FilterPredicate(Person person)
        {
            return person.name == Name;
        }
    }
}
