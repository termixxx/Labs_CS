using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Model
{
    public class Continent
    {
        private string name = "undefined";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Continent(string name)
        {
            this.name = name;
        }

    }
}
