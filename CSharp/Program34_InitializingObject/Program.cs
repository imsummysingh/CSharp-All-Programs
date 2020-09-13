using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program34_InitializingObject
{
    public class Dog
    {
        string name;
        string breed;
        int age;
        string color;

        public Dog(string name, string breed, int age, string color)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;
        }

        public string getName()
        {
            return name;
        }

        public string getBreed()
        {
            return breed;
        }

        public int getAge()
        {
            return age;
        }

        public string getColor()
        {
            return color;
        }

        public void getDetails()
        {
            Console.WriteLine("The Details Are : {0}, {1}, {2}, {3}", getName(), getBreed(), getAge(), getColor());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog obj = new Dog("Rex", "Pup", 2, "Light Brown");
            obj.getName();
            obj.getBreed();
            obj.getAge();
            obj.getColor();
            obj.getDetails();
            Console.ReadLine();
        }
    }
}
