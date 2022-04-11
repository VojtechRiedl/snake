using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    public class snake
    {
        public List<Panel> snake1 = new List<Panel>();
        public List<Panel> snake2 = new List<Panel>();
        public string smer;
        public int rychlost;

        public snake(string smer, int rychlost)
        {
            this.smer = smer;
            this.rychlost = rychlost;
        }

    }
}
