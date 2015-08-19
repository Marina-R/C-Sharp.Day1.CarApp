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
            MyCar bmw = new MyCar();
            bmw.StartTheCar();
            bmw.MakeATurn();
            bmw.Year = 2010;
            bmw.Color = "Red";
            MyCar.DriveTheCar();
            MyCar.MakeASound();
        }
    }
}
