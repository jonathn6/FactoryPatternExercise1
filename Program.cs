using System;

namespace FactoryPatternExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Pattern Exercise!");

            bool loopControl = false;
            int numberOfWheels = 99;

            do
            {
                Console.Write("How many wheels does this vehicle have? ");
                loopControl = int.TryParse(Console.ReadLine(), out numberOfWheels);

                if (!loopControl)
                {
                    Console.WriteLine("You must enter a valid number of wheels");
                    numberOfWheels = 99;
                }
                else
                {
                    if (numberOfWheels > 0)
                    {
                        var vehicle = VehicleFactory.GetVehicle(numberOfWheels);
                        vehicle.Drive();
                    }
                }


            } while (numberOfWheels > 0);
        }
    }
}
