using System;
namespace Project361.Data
{
    public class CardHelper
    {
        public static int GetCardRank(int id)
        {
            int result = id % 13;

            if (result == 0)
            {
                return 13;
            }

            return result;
        }

        public static string GetCardSuite(int id)
        {
            string result = "";

            if (id <= 13)
            {
                result = "Spades";
            }
            else if (id <= 26)
            {
                result = "Hearts";
            }
            else if (id <= 39)
            {
                result = "Clubs";
            }
            else
            {
                result = "Diamonds";
            }

            return result;
        }
    }
}


