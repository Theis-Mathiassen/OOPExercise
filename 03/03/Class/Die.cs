using System;
using _03.Interface;

namespace _03.Class
{
    public class Die : GameObject, IGameObject
    {
        private int numberOfEyes;
        private Random randomNumberSupplier;
        private readonly int maxNumberOfEyes;

        public Die() : this(6) { }

        public Die(int maxNumberOfEyes)
        {
            randomNumberSupplier =
              new Random(unchecked((int)DateTime.Now.Ticks));
            this.maxNumberOfEyes = maxNumberOfEyes;
            numberOfEyes = NewTossHowManyEyes();
        }

        public void Toss()
        {
            numberOfEyes = NewTossHowManyEyes();
        }

        private int NewTossHowManyEyes()
        {
            return randomNumberSupplier.Next(1, maxNumberOfEyes + 1);
        }

        public int NumberOfEyes()
        {
            return numberOfEyes;
        }

        public override string ToString()
        {
            return string.Format("Die[{0}]: {1}", maxNumberOfEyes, numberOfEyes);
        }

        public int GameValue
        {
            get
            {
                return numberOfEyes;
            }
        }

        public GameObjectMedium Medium
        {
            get
            {
                return
                 GameObjectMedium.Plastic;
            }
        }

    }
}
