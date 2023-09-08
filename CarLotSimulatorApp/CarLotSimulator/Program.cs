using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Make, Model, Year, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instantiate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            ////Console.WriteLine($"Your car make is {car1.Make}, the model is {car1.Model}, the year is {car1.Year}!");//, " +
            ////                                                                                                        //$"it sounds like {car1.EngineNoise}, honks like {car1.HonkNoise} " +
            ////                                                                                                        //$"and it is {car1.IsDriveable} that it still drives!");

            Car car1 = new Car("Jeep", "Cherokee", 2001, "waaaah", "jeep jeep", true);
            Console.WriteLine($"Your car make is {car1.Make}, the model is {car1.Model}, the year is {car1.Year}, " +
                $"and it is {car1.IsDriveable} that it still drives!");
            //Calling the methods
            car1.MakeEngineNoise("waaaah");
            car1.MakeHonkNoise("jeep jeep");
            Console.WriteLine();


            Car car2 = new Car();
            car2.Make = "Ford";
            car2.Model = "Mustang";
            car2.Year = 1995;
            car2.EngineNoise = "Vrooooom";
            car2.HonkNoise = "ba na na na na na na na na na naaaaaa";
            car2.IsDriveable = true;
            Console.WriteLine($"Your car make is {car2.Make}, the model is {car2.Model}, the year is {car2.Year}, " +
                $"and it is {car2.IsDriveable} that it still drives!");
            //Calling the methods
            car2.MakeEngineNoise("Vrooooom");
            car2.MakeHonkNoise("ba na na na na na na na na na naaaaaa");
            Console.WriteLine();


            Car car3 = new Car()
            {
                Make = "Cadillac",
                Model = "Fleetwood Brougham",
                Year = 1977,
                EngineNoise = "hummmmmmmmmmm",
                HonkNoise = "woh woh",
                IsDriveable = true
            };
            Console.WriteLine($"Your car make is {car3.Make}, the model is {car3.Model}, the year is {car3.Year}, " +
                $"and it is {car3.IsDriveable} that it still drives!");
            //Calling the methods
            car3.MakeEngineNoise("hummmmmmmmmmm");
            car3.MakeHonkNoise("woh woh");
            Console.WriteLine();


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instantiate Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of the cars' Make, Model, and Year to the console

            CarLot carLot1 = new CarLot();
            carLot1.Cars.Add(car1);
            carLot1.Cars.Add(car2);
            carLot1.Cars.Add(car3);

            foreach (var car in carLot1.Cars)
            {
                Console.WriteLine($"Make: {car.Make};..... Model: {car.Model};..... Year: {car.Year}");
                Console.WriteLine();
            }

            Console.WriteLine($"You now own {CarLot.numberOfCars} cars!!");

        }
    }
}
