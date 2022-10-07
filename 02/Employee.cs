namespace _02
{
    class Employee : Person
    {

        private int seniorityLevel;     

        public int SeniorityLevel
        {
            get { return seniorityLevel; }
            set { seniorityLevel = value; }
        }

        private string jobTitle;
        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee(int age, string name, string jobTitle, decimal salary, int seniorityLevel) : base (age, name)
        {
            this.jobTitle = jobTitle;
            this.salary = salary;
            this.seniorityLevel = seniorityLevel;
        }

        public virtual decimal CalculateYearlySalary ()
        {
            return salary * 12 * (1 + seniorityLevel * 0.1M);
        }
    }

}
