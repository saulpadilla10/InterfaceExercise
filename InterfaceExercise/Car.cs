using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public string Color { get; set; }
        public string Tint { get; set; }
        public string SedanSize { get; set; }
        public string Turbo { get; set; }
        public string Name { get; set; }
        public string MaintOffer { get; set; }

        public void Transmission()
        {
            Console.WriteLine($"{GetType().Name} comes in automatic. Manual available as special order.");
        }

        public void BackUp()
        {
            Console.WriteLine($"Since 2018, all vehicles come equipped with backup camera includes this {GetType().Name}.");
        }
    }
}

