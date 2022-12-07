using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            CarLot carLot = new CarLot();
            
            Car car1 = new Car();
            car1.Year = 2007;
            car1.Make = "Toyota";
            car1.Model = "Camry Hybrid";
            car1.EngineNoise = "vroom vroom";
            car1.HonkNoise = "beep beep";
            car1.IsDriveable = true;

            car1.MakeEngineNoise($"The {car1.Model}'s engine goes {car1.EngineNoise}");
            car1.MakeHonkNoise($"The {car1.Model}'s horn goes {car1.HonkNoise}");

            carLot.listOfCars.Add(car1);

            Car car2 = new Car() 
            { Year = 1952, 
              Make = "Buick", 
              Model = "Roadmaster", 
              EngineNoise = "cu-clunk cu-clunk",
              HonkNoise = "buorrrrrrr!",
              IsDriveable = false
            };

            car2.MakeEngineNoise($"The {car2.Model}'s engine goes {car2.EngineNoise}");
            car2.MakeHonkNoise($"The {car2.Model}'s horn goes {car2.HonkNoise}");

            carLot.listOfCars.Add(car2);

            Car car3 = new Car(1988, "Chevy", "Corvette", "prrr prrr", "honk honk", true);

            car3.MakeEngineNoise($"The {car3.Model}'s engine goes {car3.EngineNoise}");
            car3.MakeHonkNoise($"The {car3.Model}'s horn goes {car3.HonkNoise}");

            carLot.listOfCars.Add(car3);

            foreach (var car in carLot.listOfCars)
            {
                Console.Write(car.Year + " ");
                Console.Write(car.Make + " ");
                Console.Write(car.Model);
                Console.WriteLine();
            }


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
