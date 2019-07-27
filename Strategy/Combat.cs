using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// The Strategy abstract class, which defines an interface common to all supported strategy algorithms.
    /// </summary>
    abstract class CombatStrategy
    {
        public abstract void Attack(Mob mob);
    }

    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    class OneHandedSlash : CombatStrategy
    {
        public override void Attack(Mob mob)
        {
            var attack = (mob.Strength / 5) + (mob.SkillOneHandedSlash / 5) / 100;
            Console.Write($"One Handed Slashing: You attack with a roll of {attack}");
        }
    }

    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    class Archery : CombatStrategy
    {
        public override void Attack(Mob mob)
        {
            var attack = (mob.Dexterity / 5) + (mob.SkillArchery / 5) / 100;
            Console.Write($"Archery: You attack with a roll of {attack}");
        }
    }

    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    class Piercing : CombatStrategy
    {
        public override void Attack(Mob mob)
        {
            var attack = (((mob.Dexterity / 5) + (mob.Strength / 5)) / 2) + (mob.SkillPiercing / 5) / 100;
            Console.Write($"Piercing: You attack with a roll of {attack}");
        }
    }

    enum WeaponType
    {
        OneHandedSlash,
        Archery,
        Piercing
    }
    
    /// <summary>
    /// The Context class, which maintains a reference to the chosen Strategy.
    /// </summary>
    class Mob
    {
        public int Strength;
        public int Dexterity;

        public int SkillOneHandedSlash;
        public int SkillPiercing;
        public int SkillArchery;
        
        private CombatStrategy _combatStrategy;

        public Mob(int strength, int dexterity, int skillArchery, int skillOneHandedSlash, int skillPiercing)
        {
            Strength = strength;
            Dexterity = dexterity;
            SkillArchery = skillArchery;
            SkillOneHandedSlash = skillOneHandedSlash;
            SkillPiercing = skillPiercing;
        }
        
        public void SetCombatStrategy(WeaponType type)
        {
            switch (type)
            {
                case WeaponType.Archery:
                    this._combatStrategy = new Archery();
                    break;
                case WeaponType.OneHandedSlash:
                    this._combatStrategy = new OneHandedSlash();
                    break;
                case WeaponType.Piercing:
                    this._combatStrategy = new Piercing();
                    break;
                default:
                    this._combatStrategy = new OneHandedSlash();
                    break;
            }
        }
        
        public void Attack()
        {
            _combatStrategy.Attack(this);
            Console.WriteLine();
        }
    }
}