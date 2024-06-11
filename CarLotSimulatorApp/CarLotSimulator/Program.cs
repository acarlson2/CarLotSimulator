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

            CarLot lot = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars
            Car suv = new Car();
            Car truck = new Car();
            Car convert = new Car();

            
            //Set the properties for each of the cars
            suv.Year = 2020;
            suv.Make = "Honda";
            suv.Model = "Pilot";
            suv.EngineNoise = "BRRRRRRR";
            suv.HonkNoise = "HONK!";

            truck.Year = 2023;
            truck.Make = "Ford";
            truck.Model = "F-150";
            truck.EngineNoise = "GRRRRR";
            truck.HonkNoise = "BRONK!";

            convert.Year = 2024;
            convert.Make = "Chevrolet";
            convert.Model = "Corvette";
            convert.EngineNoise = "VRRRRRR";
            convert.HonkNoise = "BEEP!";

            lot.Lot.Add(suv);
            lot.Lot.Add(truck);
            lot.Lot.Add(convert);

            foreach(Car car in lot.Lot)
            {
                Console.WriteLine(car.Year);
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
                Console.WriteLine("");
            }

            //Call each of the methods for each car
            suv.MakeEngineNoise(suv.EngineNoise);
            suv.MakeHonkNoise(suv.HonkNoise);

            truck.MakeEngineNoise(truck.EngineNoise);
            truck.MakeHonkNoise(truck.HonkNoise);

            convert.MakeEngineNoise(convert.EngineNoise);
            convert.MakeHonkNoise(convert.HonkNoise);
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
