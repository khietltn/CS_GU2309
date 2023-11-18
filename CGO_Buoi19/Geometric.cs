using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi19
{
    public abstract class Geometric
    {
        private string name;

        public Geometric(string name="NoName")
        {
            this.name = name;
        }

        public string Name { get => name; }

        public abstract double getArea();   // { return 0; }
        public abstract double getPer();    // { return 0; }
    }
}
