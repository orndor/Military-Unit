using System;

//This CS files contains the Personnel class and all sub-classes (the different ranks).

namespace Military_Unit
{
    class Personnel
    {
        protected enum Rank
        {
            Specialist,
            NCO,
            Chief,
            Lieutenant,
            Commander,
        };
        protected readonly Rank rank;
        protected Personnel(Rank rank)
        {
            this.rank = rank;
        }
        public virtual void PrepareForTheField()
        {
            Console.WriteLine($"\nThe {rank} prepares to go to the field...");
        }
        public virtual void PrepareForTheRange()
        {
            Console.WriteLine($"\nThe {rank} goes to the range...");
        }
        public virtual void PrepareForTravel()
        {
            Console.WriteLine($"\nThe {Personnel.Rank.Specialist}s are responsible for driving all vheciles to the field.");
        }
        public virtual void March()
        {
            Console.WriteLine($"The {rank} marches normally.");
        }
        public virtual void Yell()
        {
            Console.WriteLine($"The {rank} yells at a normal volume.");
        }
        public virtual void Work()
        {
            Console.WriteLine($"The {rank} works at a medium pace.");
        }
    }
    class Specialist : Personnel
    {
        protected Specialist(Rank rank) : base(Rank.Specialist)
        {
        }
        public Specialist() : this(Rank.Specialist)
        {
        }
        public override void March()
        {
            Console.WriteLine($"The {rank} marches like he is told to but makes up his own words for the cadence.");
        }
        public override void Yell()
        {
            Console.WriteLine($"The {rank} yells at the top of his lungs in the most sarcastic way possible.");
        }
        public override void Work()
        {
            Console.WriteLine($"The {rank} finds a place to hide and play Nintendo Switch.");
        }
    }
    class NCO : Personnel
    {
        protected NCO(Rank rank) : base(Rank.NCO)
        {
        }
        public NCO() : this(Rank.NCO)
        {
        }
        public override void March()
        {
            Console.WriteLine($"The {rank} marches the {Rank.Specialist}s around and is frustrated with their attitude.");
        }
        public override void Yell()
        {
            Console.WriteLine($"The {rank} yells at the top of his lungs at the {Rank.Specialist}.");
        }
        public override void Work()
        {
            Console.WriteLine($"The {rank} spends most of his time trying to find the {Rank.Specialist}s to figure out why they aren't working.");
        }
    }
    class Warrant : Personnel
    {
        protected Warrant(Rank rank) : base(Rank.Chief)
        {
        }
        public Warrant() : this(Rank.Chief)
        {
        }
        public override void March()
        {
            Console.WriteLine($"When it comes time for marching, {rank} is no where to be found.");
        }
        public override void Yell()
        {
            Console.WriteLine($"{rank} yells \"If at first you don't succeed, trying doing it the way Chief told you to the first time,\" and then laughs meniacally.");
        }
        public override void Work()
        {
            Console.WriteLine($"It is rare to see {rank} working, but when he does, he always has a cup of coffee in his hand.");
        }
    }
    class LT : Personnel
    {
        protected LT(Rank rank) : base(Rank.Lieutenant)
        {
        }
        public LT() : this(Rank.Lieutenant)
        {
        }
        public override void March()
        {
            Console.WriteLine($"The {rank} marches along with the other Soldiers, until First Sergeant whispers in his ear to get out of his formation.");
        }
        public override void Yell()
        {
            Console.WriteLine($"The {rank} yells \"Guys, I think we are lost...\"");
        }
        public override void Work()
        {
            Console.WriteLine($"The {rank} works behind a desk, but is really daydreaming about being the CO.");
        }
    }
    class CO : Personnel
    {
        protected CO(Rank rank) : base(Rank.Commander)
        {
        }
        public CO() : this(Rank.Commander)
        {
        }
        public override void March()
        {
            Console.WriteLine($"The {rank} marches at the head of the formation, blissfuly unaware of what's going on behind him.");
        }
        public override void Yell()
        {
            Console.WriteLine($"The {rank} yells \"LT, get in my office!\"");
        }
        public override void Work()
        {
            Console.WriteLine($"The {rank} works by calling a meeting to coordinate a meeting later that afternoon.");
        }
    }
}
