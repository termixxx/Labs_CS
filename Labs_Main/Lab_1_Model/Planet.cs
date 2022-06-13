using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Model
{
    public class Planet
    {
        private string name = "undefined";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private List<Continent> Continents = new List<Continent>();
        private List<Ocean> Oceans = new List<Ocean>();
        private List<Island> Islands = new List<Island>();
        public Planet(string name)
        {
            this.name = name;
        }
        public void AddContinent(Continent name)
        {
            Continents.Add(name);
        }
        public void AddOcean(Ocean name)
        {
            Oceans.Add(name);
        }
        public void AddIsland(Island name)
        {
            Islands.Add(name);
        }
        public int CountOfContinents()
        {
            return Continents.Count();
        }
        public int CountOfOceans()
        {
            return Oceans.Count();
        }
        public int CountOfIslands()
        {
            return Islands.Count();
        }
        public List<Continent> GetContinents()
        {
            return Continents;
        }
        public List<Ocean> GetOceans()
        {
            return Oceans;
        }
        public List<Island> GetIslands()
        {
            return Islands;
        }
    }
}
