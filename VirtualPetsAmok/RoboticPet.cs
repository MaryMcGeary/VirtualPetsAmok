using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class RoboticPet : VirtualPet
    {
        // Info

        public string Model { get; private set; }
        public int Version { get; private set; }
        public string Material { get; private set; }

        // Stats
        public int Maintenance { get; private set; }
        public int TimeSinceLastCharge { get; private set; }
        public int CPUTemp { get; private set; }
        public int IdleTime { get; private set; }

        // Construct to set stats
        public RoboticPet()
        {

        }
        public RoboticPet(string name, string type, string model, int version, string material) : base(name, type)
        {
            // Set Stats
            Maintenance = 0;
            TimeSinceLastCharge = 0;
            CPUTemp = 0;
            IdleTime = 0;
            Model = model;
            Version = version;
            Material = material;
        }

        public override void DisplayPetInfo()
        {
            Console.WriteLine("\nName: " + Name);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Version: " + Version);
            Console.WriteLine("Material: " + Material);
        }

        public override void DisplayPetStats()
        {
            Console.WriteLine("\nMaintenance: " + Maintenance);
            Console.WriteLine("Time Since Last Charge: " + TimeSinceLastCharge);
            Console.WriteLine("CPU Temperature: " + CPUTemp);
            Console.WriteLine("Idle Time: " + IdleTime);
        }

        public void Computate()
        {
            Console.WriteLine("\nYou had your pet computate something!");

            // Good
            if (IdleTime > 0)
            {
                IdleTime -= 10;
                Console.WriteLine(Name + "'s Idle Time dropped! :)");
            }

            // Good
            if (CPUTemp < 100)
            {
                CPUTemp += 10;
                Console.WriteLine(Name + "'s CPU Temperature rose! :)");
            }

            // Bad
            if (TimeSinceLastCharge < 100)
            {
                TimeSinceLastCharge += 10;
                Console.WriteLine(Name + "'s Time Since Last Charge rose! :(");
            }
            else if (TimeSinceLastCharge == 100 && Maintenance < 100)
            {
                Maintenance += 10; // Physical activity while starving lowers health
                Console.WriteLine(Name + "'s Need for Maintenance rose! :(");
            }

            if (Maintenance == 100)
            {
                Console.WriteLine("\nEmergency! Take your robot for maintenance immediately!");
            }
        }

        public void Charge()
        {
            Console.WriteLine("\nYou Charged your robot!");

            // Good
            if (CPUTemp > 0)
            {
                CPUTemp -= 10;
                Console.WriteLine(Name + "'s CHARGE fell! :)");
            }

            // Good
            if (TimeSinceLastCharge > 0)
            {
                TimeSinceLastCharge -= 10;
                Console.WriteLine(Name + "'s Time since last charged dropped! :)");
            }
            else if (TimeSinceLastCharge == 0 && Maintenance < 100)
            {
                Maintenance += 10; // Overfeed lowers health
                Console.WriteLine(Name + "'s MAINTENANCE rose! :(");
            }

            if (Maintenance == 100)
            {
                Console.WriteLine("\nEmergency! Take your robot for maintenance immediately!");
            }
        }

        public void TakeToRepair()
        {
            Console.WriteLine("\nYou took your robot to the repair shop!");

            // Good
            if (Maintenance > 0)
            {
                Maintenance = 0;
                Console.WriteLine(Name + "'s MAINTENANCE is up to date! :)");
            }

            // Bad
            if (CPUTemp < 100)
            {
                CPUTemp += 10;
                Console.WriteLine(Name + "'s CPU TEMP rose! :(");
            }

            // Bad
            if (TimeSinceLastCharge < 100)
            {
                TimeSinceLastCharge += 10;
                Console.WriteLine(Name + "'s TIME SINCE LAST CHARGE rose! :(");
            }
        }

        public override void TimeEffect()
        {
            if (TimeSinceLastCharge < 100)
            {
                TimeSinceLastCharge += 10;
            }
            else if (TimeSinceLastCharge == 100 && Maintenance < 100)
            {
                Maintenance += 10;
            }

            if (CPUTemp < 100)
            {
                CPUTemp += 10;
            }
            else if (CPUTemp == 100 && Maintenance < 100)
            {
                Maintenance += 10;
            }

            if (IdleTime < 100)
            {
                IdleTime += 10;
            }
            else if (IdleTime == 100 && Maintenance < 100)
            {
                Maintenance += 10;
            }

            if (Maintenance == 100)
            {
                Console.WriteLine("\nEmergency! Take your robot for maintenance immediately!");
            }
        }
    }
}
