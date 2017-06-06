using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobiles;

namespace CSharpChallengeProject01
{
    class Program
    {
        static void Main(string[] args)
        {
            createCar();
        }
        static void createCar()
        {
            Car newCar = new Mobiles.Car();
            Console.WriteLine(
                "This car is a {0} {1} {2}", 
                newCar.Color = "Blue",
                newCar.Make = "Ford",
                newCar.Model = "Dragon"
            );
            newCar.driving();
            newCar.stopping();
        }
    }
}
