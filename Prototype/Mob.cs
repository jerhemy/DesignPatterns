namespace Prototype
{
    abstract class MobPrototype
    {
        public abstract MobPrototype Clone();
    }

    class Mob : MobPrototype
    {
        public string Name { get; }
        public int HP { get; }

        public Mob(string name, int hp)
        {
            Name = name;
            HP = hp;
        }

        public override MobPrototype Clone()
        {
            return MemberwiseClone() as MobPrototype;
        }
    }
}