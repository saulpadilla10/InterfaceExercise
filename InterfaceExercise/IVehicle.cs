using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        string Color { get; set; }
        string Tint { get; set;}
        void Transmission();
        void BackUp();
    }
}

