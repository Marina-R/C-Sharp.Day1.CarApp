using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class MyCar
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public void StartTheCar()
        {
            Console.WriteLine("My engine has started!!!");
        }
        public static void MakeASound() 
        {
            Console.WriteLine("Beep Beep!");
        }
        public void MakeATurn() 
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("I am turning left!");
            }
        }
        public static void DriveTheCar()
        {
            Console.Write("Please enter the number between 1-4 to drive a car");
            int userChoice = int.Parse(Console.ReadLine());

            switch(userChoice)
            {
                case 1:
                    Console.WriteLine("I am turning left!");
                    break;
                case 2:
                    Console.WriteLine("I am moving straight.");
                    break;
                case 3:
                    Console.WriteLine("I am turning right.");
                    break;
                case 4:
                    Console.WriteLine("My vehicle Stopped!");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}
