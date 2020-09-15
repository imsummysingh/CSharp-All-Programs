using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program36_Structure
{
    public struct car
    {
        public string brand;
        public string model;
        public string color;
    }
    class Program
    {
        static void Main(string[] args)
        {
            car obj;

            obj.brand = "maruti";
            obj.model = "k10";
            obj.color = "golden";

            Console.WriteLine("The details of car is : \nBrand: {0}, \nModel: {1}, \nColor: {2} ", obj.brand, obj.model, obj.color);
            Console.ReadLine();

        }
    }
}
