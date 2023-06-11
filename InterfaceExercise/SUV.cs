using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
    {

        public string Color { get; set; }
        public string Tint { get; set; }
        public string FourbyFour { get; set; }
        public string ThirdRow { get; set; }
        public string Name { get; set; }
        public string MaintOffer { get; set; }

        public void Transmission()
        {
            Console.WriteLine($"This is {GetType().Name} is automatic. No one wants to drive manual nowadays.");
        }

        public void BackUp()
        {
            Console.WriteLine($"Backup cameras, like the one in this {GetType().Name}, are now standard equipment.");
        }


    }
}

