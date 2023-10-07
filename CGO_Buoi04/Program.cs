using System;
using System.Text;

namespace CGO_Buoi04
{
    class Program
    {
        static void Main(string[] args)
        {
            //a+b= ? => 2+3=5
            int a, b;
            a = int.Parse( Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            //C1: Ghep chuoi
            Console.WriteLine(a + " + " + b + " = " + (a+b));

            //C2: Dinh dang chuoi
            Console.WriteLine("{0} + {1} = {2}",  a,   b,a+b);
            Console.WriteLine("{1} + {2} = {0}", a+b, a , b);

            Console.ReadKey();  //tam dung man hinh
        }

        
    }
    
}
