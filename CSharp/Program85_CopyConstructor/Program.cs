using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program85_CopyConstructor
{
    class technicalScriptWriter
    {
        private string topic_name;
        private int article_no;
        public technicalScriptWriter(string topic_name, int article_no)
        {
            this.topic_name = topic_name;
            this.article_no = article_no;
        }
        public technicalScriptWriter(technicalScriptWriter tech)
        {
            topic_name = tech.topic_name;
            article_no = tech.article_no;
        }

        public string Data
        {
            get
            {
                return "Topic Name: " + topic_name + " And number of article published: " + article_no.ToString();
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            technicalScriptWriter ts = new technicalScriptWriter("C# | copy constructor", 38);
            technicalScriptWriter ts1 = new technicalScriptWriter(ts);
            Console.WriteLine(ts1.Data);
            Console.ReadLine();
        }
    }
}
