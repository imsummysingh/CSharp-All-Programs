using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program48_this5
{
    //using this to declare an indexer
    class Geeks
    {
        public string[] days = new string[7];

        //declaring an indexer
        public string this[int index]
        {
            get
            {
                return days[index];
            }
            set
            {
                days[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Geeks g = new Geeks();
            g[0] = "Sun";
            g[1] = "Mon";
            g[2] = "Tues";
            g[3] = "Wed";
            g[4] = "Thurs";
            g[5] = "Friday";
            g[6] = "Sat";
            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine(g[i] + " ");                
            }
            Console.ReadLine();
        }
    }
}
