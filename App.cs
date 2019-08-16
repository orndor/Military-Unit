using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class App
    {
        public void Run()
        {
            var specalist = new Specialist();
            var nco = new NCO();
            var m4 = new M4();
            var m9 = new M9();
            var m320 = new M320();
            var hmmwv = new HMMWV();
            var wrecker = new Wrecker();
            var fiveton = new FiveTon();

            Console.WriteLine("This is a story of a unit going on an exercise to a field location.\n");
            PrepForTheField(specalist, m4);
            PrepForTheField(nco, m4);
            PrepForTheRange(specalist, m4);
            PrepForTheRange(nco, m4);
            GoOnMission(specalist, hmmwv);

        }
        static void PrepForTheField(Personnel personnel, Weapons weapon)
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
            personnel.PrepareForTravel();
            vehicle.Drive();
            vehicle.BreakDown();
            vehicle.Stop();
        }
    }
}
