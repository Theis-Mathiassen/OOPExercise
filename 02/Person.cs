namespace _02
{
    class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Person(int age, string name)
        {
            Age = age;
            this.name = name;
        }
    }


}
