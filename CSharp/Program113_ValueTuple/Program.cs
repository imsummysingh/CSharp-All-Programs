using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program113_ValueTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating value tuple using constructor
            ValueTuple<string> my_tuple = new ValueTuple<string>("Summy");
            ValueTuple<string, int> my_tuple1 = new ValueTuple<string, int>("Summy", 10);

            //creating value tuple using create method
            var my_tuple2 = ValueTuple.Create("Summy", "Singh");
            var my_tuple3 = ValueTuple.Create(10, 20, "Singh");

            //craeting value tuple using parenthesis
            //1.named member
            (int age, string name, string lang) author = (23, "Summy", "hindi");

            var author1 = (age: 23, name: "summy", lang: "english");

            //2.unnamed member
            var author2 = (23, "Ranjeet", "Kumar");

            var author3 = (10, "FCB", "Messi");

        }
    }
}
