using System;

//This CS file contains the Vehicle class and all sub-classes (different types of vehicles).

namespace Military_Unit
{
    class Vehicles
    {
        protected enum ModelName
        {
            HMMWV,
            Wrecker,
            FiveTon
        };
        protected readonly ModelName modelName;
        protected readonly int numOfWheels = 4;
        protected readonly int numOfSeats = 2;
        protected Vehicles(ModelName modelName, int numOfWheels, int numOfSeats)
        {
            this.modelName = modelName;
            this.numOfWheels = numOfWheels;
            this.numOfSeats = numOfSeats;
        }
        protected Vehicles(ModelName modelName)
        {
            this.modelName = modelName;
            this.modelName = modelName;
        }
        public virtual void Drive()
        {
            Console.WriteLine($"The {modelName} starts after pulling and pressing a bunch of levers.");
        }
        public virtual void BreakDown()
        {
            Console.WriteLine($"The {modelName} breaks down.");
        }
        public virtual void Stop()
        {
            Console.WriteLine($"The {modelName} turns off.");
        }
    }
    class HMMWV : Vehicles
    {
        protected HMMWV(ModelName modelName) : base(ModelName.HMMWV, 4, 4)
        {
        }
        public HMMWV() : this(ModelName.HMMWV)
        {
        }
        public override void BreakDown()
        {
            Console.WriteLine($"The {modelName} gets stuck in wet grass.");
        }
    }
    class Wrecker : Vehicles
    {
        protected Wrecker(ModelName modelName) : base(ModelName.Wrecker, 10, 2)
        {
        }
        public Wrecker() : this(ModelName.Wrecker)
        {
        }
        public override void BreakDown()
        {
            Console.WriteLine($"The {modelName} breaks down while pulling the HMMWV out of the wet grass.");
        }
    }
    class FiveTon : Vehicles
    {
        protected FiveTon(ModelName modelName) : base(ModelName.FiveTon, 10, 2)
        {
        }
        public FiveTon() : this(ModelName.FiveTon)
        {
        }
        public override void BreakDown()
        {
            Console.WriteLine($"The {modelName} overheats while trying to pull the wrecker back onto the road.");
        }
    }
}
