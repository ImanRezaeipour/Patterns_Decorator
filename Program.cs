using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Decorator
{
    /// <summary>
    /// Driver program for creating cars and decorating them with options.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new FerrariSpider(); //create our car
            car = new OptionLeather(car); //decorate it with the leather option
            car = new OptionAlloyWheels(car); //decorate it with the alloy wheels option
            car = new OptionTurbo(car); //decorate it with the turbo option
            Console.WriteLine("Description-->" + car.Description.TrimEnd(' ',','));
            Console.WriteLine("Cost-->" + car.Cost.ToString());
            Console.ReadLine();
        }
    }
}
