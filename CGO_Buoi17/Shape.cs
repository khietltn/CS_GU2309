using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi17
{
    class Shape
    {
        public void Draw()
        {
            Console.WriteLine("Draw shape!");
        } 
    }
    class Circle : Shape
    {
        public  void Draw()
        {
            Console.WriteLine("Draw circle!");
        }
    }
    class Rectangle: Shape
    {
        public  void Draw()
        {
            Console.WriteLine("Draw Rectangle!");
        }
    }
    class Triangle: Shape
    {
        public  void Draw()
        {
            Console.WriteLine("Draw triangle!");
        }
    }
}
