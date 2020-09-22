using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program50_ShallowCopy
{
    class CompanyDescription
    {
        public string CompanyName;
        public string Owner;

        public CompanyDescription(string c, string o)
        {
            this.CompanyName = c;
            this.Owner = o;
        }
    }

    class Company
    {
        public int GBRank;
        public CompanyDescription desc;

        public Company(int gbrank, string c, string o)
        {
            this.GBRank = gbrank;
            desc = new CompanyDescription(c, o);
        }

        //method for cloning
        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        //method for cloning object
        public Company DeepCopy()
        {
            Company deepcopyCompany = new Company(this.GBRank, desc.CompanyName, desc.Owner);
            return deepcopyCompany;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Company c1 = new Company(548, "GeeksforGeeks", "SanjeepJain");

            //performing shallow copy
            Company c2 = (Company)c1.ShallowCopy();

            Console.WriteLine("Before Chaanging: ");

            //before changing
            Console.WriteLine(c1.GBRank);
            Console.WriteLine(c2.GBRank);
            Console.WriteLine(c1.desc.CompanyName);
            Console.WriteLine(c2.desc.CompanyName);

            //changing value of c2
            c2.GBRank = 59;
            c2.desc.CompanyName = "GFG";

            Console.WriteLine("\n After Changing: ");

            Console.WriteLine(c1.GBRank);
            Console.WriteLine(c2.GBRank);
            Console.WriteLine(c1.desc.CompanyName);
            Console.WriteLine(c2.desc.CompanyName);

            Console.ReadLine();

        }
    }
}
