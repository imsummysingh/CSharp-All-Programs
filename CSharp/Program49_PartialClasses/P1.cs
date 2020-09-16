using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program49_PartialClasses
{
    public partial class Geeks
    {
        private string name;
        private int total_article;

        public Geeks(string a, int t)
        {
            this.name = a;
            this.total_article = t;
        }
    }
}
