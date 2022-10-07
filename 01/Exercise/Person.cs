using System;

namespace Exercise
{
    class Person
    {
        public long ID { get; set; }

        private string _firstName;
        public string FirstName {
            get
            {
                return _firstName;
            }
            set
            {
                if (value.Length >= 2)
                {
                    _firstName = value;
                }
                else
                {
                    throw new ArgumentException("Name to short");
                }
            }
        }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value.Length >= 2)
                {
                    _lastName = value;
                }
                else
                {
                    throw new ArgumentException("Name to short");
                }
            }
        }
        public int Age { get; set; }

        public Person Mother { get; set; }
        public Person Father { get; set; }


        public Person(Person mother, Person father, int age, string firstName, string lastName)
        {
            ID = IDSystem.GetID();
            Mother = mother;
            Father = father;
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
