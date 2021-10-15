using System;

namespace Knight
{
    abstract class Equipment
    {
        public int x;
        public int y;

        static void Main(string[] args)
        {
            
        }

        public virtual void Equip()
        {
            Console.WriteLine("Equipment slot");
        }

        public virtual void Hitbymouse(int x, int y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }

    abstract class Consumable
    {
        public virtual void Consume()
        {
            Console.WriteLine("Gulp");
        }

        public virtual void Spend()
        {
            Console.WriteLine("Money, Money, Mone- AAAAAAAAAH AAAAAAAAAAAAH AAAAAAAAAAAAAAAAAAAAAAAAH");
        }

        public bool CanConsume = true;
    }

    class Armor : Equipment
    {
        public override void Equip()
        {
            Console.WriteLine("Armor slot");
        }

        public override void Hitbymouse(int x, int y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }

    class Weapon : Equipment
    {
        public override void Equip()
        {
            Console.WriteLine("Weapon slot");
        }

        public override void Hitbymouse(int x, int y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }

    class Money : Consumable
    {
        public bool CanPickup = true;
    }

    class PotionHeal : Consumable
    {
        public override void Consume()
        {
            Console.WriteLine("Yummy Health");
        }
    }

    class PotionMana : Consumable
    {
        public override void Consume()
        {
            Console.WriteLine("Yummy Mana");
        }
    }

    
}
