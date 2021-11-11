using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Car!");
        }
    }
}
