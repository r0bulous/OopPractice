using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPractice
{
    class Dog
    {
        //Declare Fields
        private int hairLength;
        private int height;
        private int runningSpeed;
        private int weight;


        //Declare Properties

        public int HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public string Name { get; set; }

        //Declare constructors

        public Dog()
        {
            //default const
        }

        public Dog(int runningSpeed, int weight, int height, int hairLength)
        {
            this.runningSpeed = runningSpeed;
            this.weight = weight;
            this.height = height;
            this.hairLength = hairLength;
        }

        public void Run()
        {
            Console.WriteLine("Your dog can run {0} miles per hour", runningSpeed);
        }

        public void FavFood(string[] food)
        {

            Console.WriteLine("{0} favorite foods are: ", Name);
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i]);
            }

        }
    }

}