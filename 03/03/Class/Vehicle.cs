using System;
using _03.Interface;

namespace _03.Class
{

    public class FixedProperty : ITaxable
    {
        public decimal TaxValue { get; set; }

        protected string location;
        protected bool inCity;
        protected decimal estimatedValue;

        public FixedProperty(string location, bool inCity, decimal value)
        {
            this.location = location;
            this.inCity = inCity;
            estimatedValue = value;
            TaxValue = estimatedValue * 0.2m;
        }

        public FixedProperty(string location) :
          this(location, true, 1000000)
        {
        }

        public string Location
        {
            get
            {
                return location;
            }
        }

    }

    public class Vehicle : ITaxable
    {
        public decimal TaxValue { get; set; }

        protected int registrationNumber;
        protected double maxVelocity;
        protected decimal value;

        public Vehicle(int registrationNumber, double maxVelocity,
                       decimal value)
        {
            this.registrationNumber = registrationNumber;
            this.maxVelocity = maxVelocity;
            this.value = value;
            TaxValue = this.value * 0.3m;
        }

        public int RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }
        }

    }

    public class Bus : Vehicle
    {

        protected int numberOfSeats;

        public Bus(int numberOfSeats, int regNumber, decimal value) :
            base(regNumber, 80, value)
        {
            this.numberOfSeats = numberOfSeats;
        }

        public int NumberOfSeats
        {
            get
            {
                return numberOfSeats;
            }
        }

    }

    public class House : FixedProperty
    {

        protected double area;

        public House(string location, bool inCity, double area,
                     decimal value) :
            base(location, inCity, value)
        {
            this.area = area;
        }

        public double Area
        {
            get
            {
                return area;
            }
        }
    }

}
