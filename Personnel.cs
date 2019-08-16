using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

//This CS files contains the Personnel class and all sub-classes (the different ranks)

namespace Military_Unit
{
    class Personnel
    {
        protected enum Rank
        {
            Specialist,
            NCO,
            Warrant,
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
            Console.WriteLine($"\nThe {rank}s prepares to go to the field...");
        }
        public virtual void PrepareForTheRange()
        {
            Console.WriteLine($"\nThe {rank}s prepares for the range...");
        }
        public virtual void PrepareForTravel()
        {
            Console.WriteLine($"\nThe {rank}s begin their travel to the field...");
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
            Console.WriteLine($"The {rank} yells at the top of his lungs at the {Rank.Specialist}");
        }
        public override void Work()
        {
            Console.WriteLine($"The {rank} spends most of his time trying to find the Lower Enlisted to figure out why they aren't working.");
        }
    }
}
