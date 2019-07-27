using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var Player = new Mob(100, 120, 75, 50, 150);
            
            Player.SetCombatStrategy(new Archery());
            Player.Attack();
            
            Player.SetCombatStrategy(new Piercing());
            Player.Attack();
            
            Player.SetCombatStrategy(new OneHandedSlash());
            Player.Attack();
        }
    }
}
