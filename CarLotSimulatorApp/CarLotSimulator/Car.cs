using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property

        public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDriveable)
        {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        public Car()
        {

        }


        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; } 
        
        public bool IsDriveable { get; set; }


        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        } 
            
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }
            
    }
}
