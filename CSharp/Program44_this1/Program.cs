using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program44_this1
{
    //using this keyword to refer current class instance member
    class Geeks
    {
        public string Name;

        public string GetName()
        {
            return Name;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Geeks obj = new Geeks();
            obj.SetName("Summy Singh");
            Console.WriteLine(obj.GetName());
            Console.ReadLine();
        }
    }
}
