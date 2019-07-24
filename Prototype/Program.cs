using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize with default sandwiches
            var orc = new Mob("Orc", 10);
            var troll = new Mob("Troll", 30);

            Console.WriteLine($"Orc: {orc.Name}/{orc.HP}");
            Console.WriteLine($"Troll: {troll.Name}/{troll.HP}");
            
            // Now we can clone the sandwiches.
            var orc1 = orc.Clone() as Mob;
            var troll1 = troll.Clone() as Mob;

            
            Console.WriteLine($"Orc 1: {orc1.Name}/{orc1.HP}");
            Console.WriteLine($"Troll 1: {troll1.Name}/{troll1.HP}");
        }
    }
}
