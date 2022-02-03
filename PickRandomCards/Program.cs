namespace PickRandomCards
{
    public static class CardPicker
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();

            if(int.TryParse(line, out int numberOfCards))
            {
                string[] cards = CardPicker.PickSomeCards(numberOfCards);

                foreach(string card in cards)
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for(int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);

            if(value == 1)
            {
                return "Spades";
            }
            if(value == 2)
            {
                return "Hearts";
            }
            if(value == 3)
            {
                return "Clubs";
            }
            return "Diamonds";
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);

            if(value == 1)
            {
                return "Ace";
            }
            if(value == 11)
            {
                return "Jack";
            }
            if(value == 12)
            {
                return "Queen";
            }
            if(value == 13)
            {
                return "King";
            }
            return value.ToString();
        }
    }
}