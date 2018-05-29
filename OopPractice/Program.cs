using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog wooffie = new Dog(12, 43, 20, 0);
            wooffie.Run();
            Dog spot = new Dog();
            spot.RunningSpeed = 50;
            spot.Run();
        }
    }
}
