using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program109_CreateStringUsingProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Geeks for Geeks";

            //extract second word
            
            int startpos = sentence.IndexOf(" ") + 1;

            int endpos = sentence.IndexOf(" ", startpos) - startpos;

            string wrd = sentence.Substring(startpos, endpos);

            Console.WriteLine(wrd);
            Console.ReadLine();
        }
    }
}
