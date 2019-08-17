using System;

//This CS files contains the Weapons class and all sub-classes (different types of weapons); Weapons is an abstract class due to weapon "Capacity"

namespace Military_Unit
{
    abstract class Weapons
    {
        protected enum Weapon
        {
            M9,
            M4,
            M320,
            Glock
        };
        protected enum Caliber
        {
            NATO556MM,
            NATO9MM,
            NATO40MM,
        };
        protected readonly Weapon weapon;
        protected readonly Caliber caliber;
        protected Weapons(Weapon weapon, Caliber caliber)
        {
            this.weapon = weapon;
            this.caliber = caliber;
        }
        public abstract int Capacity();
        public virtual void Shoot()
        {
            Console.WriteLine($"The {weapon} goes pew.");
        }
        public virtual void Reload()
        {
            Console.WriteLine($"The {weapon} is reloaded with a {Capacity()} round magazine, which contains {caliber} ammunition.");
        }
        public virtual void Malfunction()
        {
            Console.WriteLine($"The {weapon} malfuntions");
        }
    }
    class M9 : Weapons
    {
        protected M9(Weapon weapon) : base(Weapon.M9, Caliber.NATO9MM)
        {

        }
        public M9() : this(Weapon.M9)
        {
        }
        public override void Malfunction()
        {
            Console.WriteLine($"The {weapon} malfunctions after the first shot.");
        }
        public override int Capacity()
        {
            return 15;
        }
    }
    class M4 : Weapons
    {
        protected M4(Weapon weapon) : base(Weapon.M4, Caliber.NATO556MM)
        {
        }
        public M4() : this(Weapon.M4)
        {
        }
        public override void Shoot()
        {
            Console.WriteLine($"The {weapon} goes pew, pew, pew.");
        }
        public override void Malfunction()
        {
            Console.WriteLine($"The {weapon} malfunctions after a short three-round burst.");
        }
        public override int Capacity()
        {
            return 30;
        }
    }
    class M320 : Weapons
    {
        protected M320(Weapon weapon) : base(Weapon.M320, Caliber.NATO40MM)
        {
        }
        public M320() : this(Weapon.M320)
        {
        }
        public override void Shoot()
        {
            Console.WriteLine($"The {weapon} goes thump.");
        }
        public override void Reload()
        {
            Console.WriteLine($"The {weapon} is reloaded with {Capacity()} round which is {caliber}!");
        }
        public override void Malfunction()
        {
            Console.WriteLine($"The {weapon} malfunctions by completely exploding.");
        }
        public override int Capacity()
        {
            return 1;
        }
    }
    class Glock : Weapons
    {
        protected Glock(Weapon weapon) : base(Weapon.Glock, Caliber.NATO9MM)
        {
        }
        public Glock() : this(Weapon.Glock)
        {
        }
        public override void Shoot()
        {
            Console.WriteLine($"No one is sure how he is allowed to bring his personal weapon to the range, but anyways the {weapon} goes pew.");
        }
        public override void Malfunction()
        {
            Console.WriteLine($"The {weapon} won't malfunction.");
        }
        public override int Capacity()
        {
            return 10;
        }
    }
}
