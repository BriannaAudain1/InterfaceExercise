using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany - DONE

            //Create 3 classes called Car , Truck , & SUV - DONE 

            //In your IVehicle - DONE 

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany - DONE 

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes - DONE

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values; - DONE 
            //Creatively display and organize their values

            var sedan = new Car()
            {
                Make = "Honda",
                Model = "Altima",
                CorpName = "BrandZ",
                Motto = "Best Brand Z Ever",
                HowManyWheels = 4,
                HasLeatherSeats = true,
                HasSteering = true,
                HasStereo = true,
                HasSunRoof = true,
                HasTrunk = true,
            };

            var truck = new Truck()
            {
                Make = "Ford",
                Model = "F-150",
                CorpName = "Landscapers Inc",
                Motto = "Trees",
                HowManyWheels = 4,
                HasSteering = true,
                HasStereo = false,
                HasSunRoof = false,
                HasTowHook = true,
                HasTruckBed = true,
                
            };

            var suv = new SUV()
            {
                Make = "Jeep",
                Model = "Wrangler Unlimited",
                CorpName = "Cool Jeeps",
                Motto = "C001 J33p5",
                FourWheelDrive = true,
                HasCargo = true,
                HowManyWheels = 4,
                HasSteering = true,
                HasStereo = true,
                HasSunRoof = true,
            };

            var vehicleList = new List<IVehicle>() { sedan, truck, suv };

            foreach (var car in vehicleList) 
            {
                Console.WriteLine($"Vehicle {car.Make} {car.Model} has {car.HowManyWheels} wheels. It is {car.HasSteering} it has a steering wheel.");
            }
        }
    }
}
