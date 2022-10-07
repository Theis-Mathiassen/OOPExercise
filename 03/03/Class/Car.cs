using System;

namespace _03.Class
{
    class Car : IComparable
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public decimal Price { get; private set; }

        public Car(string make, string model, decimal price)
        {
            Make = make;
            Model = model;
            Price = price;
        }

        public int CompareTo(object obj)
        {
            if (obj is Car otherCar)
            {
                return (int)(Price - otherCar.Price);
            }
            throw new ArgumentException("Wrong type");
        }
    }

}
