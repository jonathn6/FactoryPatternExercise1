using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    class BigRig : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Big Rig!");
        }
    }
}
