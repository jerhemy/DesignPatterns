using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var Player = new Mob(100, 120, 75, 50, 150);
            
            Player.SetCombatStrategy(WeaponType.Archery);
            Player.Attack();
            
            Player.SetCombatStrategy(WeaponType.OneHandedSlash);
            Player.Attack();
            
            Player.SetCombatStrategy(WeaponType.Piercing);
            Player.Attack();
        }
    }
}
