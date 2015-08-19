using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var BMW = new Car();
            BMW.startTheCar();
            BMW.makeATurn();
            BMW.year = 2010;
            BMW.color = "Red";

            //how to use a static method?
        }
    }
}
