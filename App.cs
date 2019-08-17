using System;

//The output of this program will exceed the normal console scroll buffer; increase the scroll buffer in the cmd window to see all output.

namespace Military_Unit
{
    class App
    {
        public void Run()
        {
            var specalist = new Specialist();
            var nco = new NCO();
            var warrant = new Warrant();
            var lt = new LT();
            var co = new CO();
            var m4 = new M4();
            var m9 = new M9();
            var m320 = new M320();
            var glock = new Glock();
            var hmmwv = new HMMWV();
            var wrecker = new Wrecker();
            var fiveton = new FiveTon();

            Console.WriteLine("\nThis is a story of a unit going on an exercise to a field location.");
            PrepForTheField(specalist);
            PrepForTheField(nco);
            PrepForTheField(warrant);
            PrepForTheField(lt);
            PrepForTheField(co);

            PrepForTheRange(specalist, m320);
            PrepForTheRange(nco, m4);
            PrepForTheRange(warrant, glock);
            PrepForTheRange(lt, m4);
            PrepForTheRange(co, m9);

            Console.WriteLine($"\nThe Specialits are responsible for driving all vehicles to the field:");
            GoOnMission(specalist, hmmwv);
            Console.WriteLine(" ");
            GoOnMission(specalist, wrecker);
            Console.WriteLine(" ");
            GoOnMission(specalist, fiveton);

        }
        static void PrepForTheField(Personnel personnel)
        {
            personnel.PrepareForTheField();
            personnel.Yell();
            personnel.March();
            personnel.Work();
        }
        static void PrepForTheRange(Personnel personnel, Weapons weapon)
        {
            personnel.PrepareForTheRange();
            weapon.Shoot();
            weapon.Reload();
            weapon.Malfunction();
        }
        static void GoOnMission(Personnel personnel, Vehicles vehicle)
        {
            vehicle.Drive();
            vehicle.BreakDown();
            vehicle.Stop();
        }
    }
}
