using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new EquipmentCollection
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
            EquipmentIterator iterator = collection.CreateIterator();

            Console.WriteLine("Gimme all the jelly beans!");

            for (Item item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }
}
