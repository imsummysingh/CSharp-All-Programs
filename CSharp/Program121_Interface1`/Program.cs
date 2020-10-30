using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program121_Interface1
{
    interface vehicle
    {
        void changeGear(int a);
        void speedUp(int a);
        void applyBrakes(int a);
    }

    class Bicycle: vehicle
    {
        int speed;
        int gear;

        public void changeGear(int newGear)
        {
            gear = newGear;
        }
        public void speedUp(int increment)
        {
            speed = speed + increment;
        }
        public void applyBrakes(int dercrement)
        {
            speed = speed - dercrement;
        }
        public void printStates()
        {
            Console.WriteLine("Speed: {0} & Gear: {1}", speed, gear);
        }

    }

    class Bike: vehicle
    {

        int speed;
        int gear;

        public void changeGear(int newGear)
        {
            gear = newGear;
        }
        public void speedUp(int increment)
        {
            speed = speed + increment;
        }
        public void applyBrakes(int dercrement)
        {
            speed = speed - dercrement;
        }
        public void printStates()
        {
            Console.WriteLine("Speed: {0} & Gear: {1}", speed, gear);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle b = new Bicycle();
            b.changeGear(2);
            b.speedUp(3);
            b.applyBrakes(1);

            Console.WriteLine("Bicycle Status:");
            b.printStates();

            Bike b1 = new Bike();
            b1.changeGear(1);
            b1.speedUp(2);
            b1.applyBrakes(1);
            Console.WriteLine("Bike Status:");
            b1.printStates();

            Console.ReadLine();

        }
    }
}
