using System;
namespace ReturnValue
{
    class Player
    {
        static int luck = 5;
        static Random randomNumber = new Random();
        public static int points = 0;
        public static bool Luck()
        {
            int karma = randomNumber.Next(10);
            bool result = false;
            if (luck>=karma)
            {result = true; }
            return result;
        }
    }
}