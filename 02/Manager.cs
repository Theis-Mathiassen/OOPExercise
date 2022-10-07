namespace _02
{
    class Manager : Employee
    {
        private decimal yearlyBonus;

        public decimal YearlyBonus
        {
            get { return yearlyBonus; }
            set { yearlyBonus = value; }
        }

        public Manager(int age, decimal yearlyBonus, string name, string jobTitle, decimal salary, int seniorityLevel) : base(age, name, jobTitle, salary, seniorityLevel)
        {
            this.yearlyBonus = yearlyBonus;
        }

        public override decimal CalculateYearlySalary()
        {
            return base.CalculateYearlySalary() + yearlyBonus;
        }
    }


}
