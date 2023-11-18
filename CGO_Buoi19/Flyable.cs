using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi19
{
    interface Flyable
    {
        string Fly(); //the hien cach bay
    }

    class Bird : Flyable
    {
        public string Fly()
        {
            return string.Format("Flying with wings");
        }
    }
    class SuperMan : Flyable
    {
        public string Fly()
        {
            return string.Format("Flying with wind");
        }
    }
}
