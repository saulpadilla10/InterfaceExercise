using System;
using System.Collections;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values


            // Create objects of Car, Truck, and SUV


            // Create objects of Car, Truck, and SUV

            
                Car challenger = new Car()
                {
                    Color = "Red",
                    Tint = "Dark",
                    SedanSize = "Technically this is a coupe.",
                    Turbo = "Not included, but can be added.",
                    Name = "Dodge",
                    MaintOffer = "3 years free oil change!! *see fine print for details."
                };

                Truck pilot = new Truck()
                {
                    Color = "Gray",
                    Tint = "Mid",
                    Diesel = "Not diesel, but premium fuel only",
                    CabSize = "Mid-size, but still roomy.",
                    Name = "Honda",
                    MaintOffer = "1 year \"worry-free\" maintenace."
                };

                SUV tiguan = new SUV()
                {
                    Color = "Egg Shell",
                    Tint = "Only the back windows come dark-tinted, don't ask why.",
                    FourbyFour = "4x4 only available with an upgrade.",
                    ThirdRow = "Three rows included, no upgrade required.",
                    Name = "Volkswagen",
                    MaintOffer = "Inspection only, not maintenance. There's a difference."
                };

            /*                var vehicles = new List<IVehicle>();

                            vehicles.Add(challenger);
                            vehicles.Add(pilot);
                            vehicles.Add(tiguan);

                            foreach (var vehicle in vehicles)
                            {
                                Console.WriteLine($"{vehicle.GetType().Name}:");
                                foreach (var property in vehicle.GetType().GetProperties())
                                {
                                    var value = property.GetValue(vehicle);
                                    Console.WriteLine($"{property.Name}: {value}");
                                }
                                Console.WriteLine();
                            }
                            challenger.BackUp();
                            challenger.Transmission();

                            pilot.BackUp();
                            pilot.Transmission();

                            tiguan.BackUp();
                            tiguan.Transmission();*/


            Console.WriteLine("CARS FOR SALE:");

            Console.WriteLine();

            Console.WriteLine("Challenger:");
            Console.WriteLine($"Color: {challenger.Color}");
            Console.WriteLine($"Tint: {challenger.Tint}");
            Console.WriteLine($"Size: {challenger.SedanSize}");
            Console.WriteLine($"Turbo: {challenger.Turbo}");
            Console.WriteLine($"Company Name: {challenger.Name}");
            Console.WriteLine($"Company Maintenance: {challenger.MaintOffer}");
            challenger.BackUp();
            challenger.Transmission();
            Console.WriteLine();

            Console.WriteLine("Pilot:");
            Console.WriteLine($"Color: {pilot.Color}");
            Console.WriteLine($"Tint: {pilot.Tint}");
            Console.WriteLine($"Fuel Type: {pilot.Diesel}");
            Console.WriteLine($"Size: {pilot.CabSize}");
            Console.WriteLine($"Company Name: {pilot.Name}");
            Console.WriteLine($"Company Maintenance: {pilot.MaintOffer}");
            pilot.BackUp();
            pilot.Transmission();
            Console.WriteLine();

            Console.WriteLine("Tiguan:");
            Console.WriteLine($"Color: {tiguan.Color}");
            Console.WriteLine($"Tint: {tiguan.Tint}");
            Console.WriteLine($"Drive: {tiguan.FourbyFour}");
            Console.WriteLine($"Seats: {tiguan.ThirdRow}");
            Console.WriteLine($"Company Name: {tiguan.Name}");
            Console.WriteLine($"Company Maintenance: {tiguan.MaintOffer}");
            tiguan.BackUp();
            tiguan.Transmission();





        }
    }
}
