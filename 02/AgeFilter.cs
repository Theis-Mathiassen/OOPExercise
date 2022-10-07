namespace _02
{
    class AgeFilter : PersonFilter
    {
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public AgeFilter(int minAge, int maxAge)
        {
            MinAge = minAge;
            MaxAge = maxAge;
        }

        public override bool FilterPredicate(Person person)
        {
            if (person.Age > MinAge && person.Age < MaxAge)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
