using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Motorcycle!");
        }
    }
}
