// See https://aka.ms/new-console-template for more information

namespace _05 // Note: actual namespace depends on the project name.
{
    class Gearbox
    {
        public int Gear { get; set; }

        public Gearbox()
        {
            Gear = 0;
        }

        void changeGear (int gear)
        {
            if ()
            if (gear == -1)
            Gear = gear;
        }
    }

    class IllegalGearChangeException : Exception
    {

    }
}

