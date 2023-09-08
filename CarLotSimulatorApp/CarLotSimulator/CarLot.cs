using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class CarLot
    {
        public CarLot() 
        {
        }

        public List<Car> Cars = new List<Car>();

        public static int numberOfCars;

       


        //Static Keyword Exercise#2:
        //Building on our CarLotSimulator project:
        //Inside the CarLot class from the previous exercise, create a static field called numberOfCars.
        //Have this number only increment when in our program we create a new Car.
        //From there, use the 3 cars in the Main() (from the previous exercise) and
        //then each time you create a car do a Console.WriteLine() printing the current number of cars in the car lot.


    }
}
