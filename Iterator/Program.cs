using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var bag = new BagOfHolding
            {
                [0] = new Item("Short Sword +1"),
                [1] = new Item("Chain Mail"),
                [2] = new Item("Gold Coin"),
                [3] = new Item("Water Skin"),
                [4] = new Item("Trail Rations"),
                [5] = new Item("Spell Book"),
                [6] = new Item("Candle"),
                [7] = new Item("Old Book"),
                [8] = new Item("Rope")
            };

            // Create iterator
            BagOfHoldingIterator iterator = bag.CreateIterator();
            
            for (Item item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }
}
