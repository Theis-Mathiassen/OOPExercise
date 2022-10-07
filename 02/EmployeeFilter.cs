namespace _02
{
    class EmployeeFilter : PersonFilter
    {
        public EmployeeFilter()
        {

        }

        public override bool FilterPredicate(Person person)
        {
            return person is Employee;
        }
    }
}
