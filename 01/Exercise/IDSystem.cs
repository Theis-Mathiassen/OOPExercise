using System;

namespace Exercise
{
    public static class IDSystem
    {
        private static byte _IDNumber;
        public static byte IDNumber { 
            get
            {
                byte result = _IDNumber;
                _IDNumber++;
                return result;
            }
            set
            {

            }
        }
        public static long GetID ()
        {
            DateTime now = DateTime.Now;
            int secondsSinceEpoch = (int)(now - DateTime.UnixEpoch).TotalSeconds;
            Random rnd = new Random();
            byte randomPart = (byte)rnd.Next();
            byte count = IDNumber;
            string idString = "" + secondsSinceEpoch + randomPart.ToString("000") + count.ToString("000");
            return Int64.Parse(idString);
        }

    }

}


