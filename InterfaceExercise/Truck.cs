using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
            public string Color { get; set; }
            public string Tint { get; set; }
            public string Diesel { get; set; }
            public string CabSize { get; set; }
            public string Name { get; set; }
            public string MaintOffer { get; set; }

            public void Transmission()
            {
                Console.WriteLine($"This {GetType().Name} comes in automatic and manual transmissions available.");
            }

            public void BackUp()
            {
                Console.WriteLine($"{GetType().Name} has a back up camera. All new vehicles sold in U.S. now require backup cameras to help prevent accidents.");
            }
  
    }
}

