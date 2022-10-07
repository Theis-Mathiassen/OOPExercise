using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using _03.Class;
using _03.Interface;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameExercise();



            
        }
        static void CarExercise ()
        {
            // Car comparison
            List<Car> cars = new List<Car>()
            {
                new Car("Skoda", "Fabia", 50000m),
                //new Car("Skoda", "Octavia", 60000m),
                new Car("Fiat", "500", 12345m),
                //new Car("Ford", "Mustang", 9000000m),
                //new Car("Ford", "Mustang", 9000001m)
            };
            
            CarComparer carComparer = new CarComparer();
            cars.Sort(carComparer);
            Console.WriteLine("Sorted by price");
            foreach (Car car in cars)
            {
                Console.WriteLine($" {car.Make} {car.Model} {car.Price}");
            }
        }

        static void TaxExercise ()
        {
            List<ITaxable> taxItems = new List<ITaxable>()
            {
                new House("Herning", true, 1000, 1500000m),
                new Bus(63, 19941559, 800000m)
            };

            foreach (ITaxable taxItem in taxItems)
            {
                //Console.WriteLine("Hello");
                Console.WriteLine("Tax value: " + taxItem.TaxValue);
            }
        }

        static void GameExercise ()
        {
            Die d1 = new Die(),
                d2 = new Die(10),
                d3 = new Die(18);

            Card c1 = new Card(Card.CardSuite.spades, Card.CardValue.queen),
                 c2 = new Card(Card.CardSuite.clubs, Card.CardValue.four),
                 c3 = new Card(Card.CardSuite.diamonds, Card.CardValue.ace);

            IGameObject[] gameObjects = { d1, d2, d3, c1, c2, c3 };

            foreach (IGameObject gao in gameObjects)
            {
                Console.WriteLine("{0}: {1} {2}",
                                  gao, gao.GameValue, gao.Medium);
            }
        }

    }
}
