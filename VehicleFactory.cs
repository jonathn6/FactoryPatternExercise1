using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfTires)
        {
            switch (numberOfTires)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                default:
                    return new BigRig();
            }
        }
    }
}
