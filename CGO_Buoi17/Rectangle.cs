using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi17
{
    class Rectangle
    {
        private double w, h;

        public Rectangle(double w=1, double h=1)
        {
            this.w = w;
            this.h = h;
        }

        public double W { get => w; set => w = value; }
        public double H { get => h; set => h = value; }

        public double getDT() { return w * h;}
        public double getCV() { return 2*(w + h); }
        public override string ToString()
        {
            return "Rectangle{" + "width=" + w + ", height=" + h + "}";
        }
    }
}
