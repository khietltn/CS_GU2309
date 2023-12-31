﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi17
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen c = new Citizen("Noname", "HNC");
            c.
            Shape s = new Shape();      //lop cha
            s.Draw();

            Circle c = new Circle();    //lop con
            c.Draw();

            Rectangle r = new Rectangle();//lop con
            r.Draw();
            ///Lớp cha gọi được hàm của lớp con (sử dụng List) 
            ///Hàm lớp cha phải có virtual
            ///Hàm lớp con override 
            Console.WriteLine("\n\n Luu vao dang mang: ");
            var shape = new List<Shape> {
                new Shape(),
                new Rectangle(),
                new Circle(),
                new Triangle()
            };
            foreach (var item in shape) item.Draw();

            /**
            //int a; a=10;      //int a=10;         // int b=a;
            PS p1= new PS(3,5);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.SayHello());

            Point A = new Point();          //int a; khai bao ten bien
            Console.WriteLine(A);
            A.setX(10);
            //A.x = 10; A.y = 5; A.z = 0;     //a=10; gan gia tri cho bien
            Console.WriteLine(A);

            Point B = new Point(0, 0, 1);   //int a=10; vua khai bao vua gan gia tri 
            Console.WriteLine(B.ToString());

            Point C = A;
            Console.WriteLine(C.ToString());
            **/
            Console.ReadKey();
        }
    }
    public class PS
    {
        private int tu, mau;

        public PS(int tu=0, int mau=1)
        {
            this.tu = tu;
            this.mau = mau;
        }

        public int Tu { get => tu; set => tu = value; }
        public int Mau { get => mau; set => mau = value; }

        public string SayHello()
        {
            return "Hello!";
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", tu, mau);
        }
        
    }
    public class Point
    {
        private int x, y, z;
        public void setX(int value) { x = value;     }
        public void setY(int value) { y = value; }
        public void setZ(int value) { z = value; }
        public int getX() { return x; }
        public int getY() { return y; }
        public int getZ() { return z; }
        //public Point() { x = 0; y = 0; z = 1; }
        public Point(int _x=0, int _y=0, int _z=0) { x = _x; y = _y; z = _z; }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", x, y, z);
        }
    } 
}
