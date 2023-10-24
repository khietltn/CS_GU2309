using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("{0:0.00}", 1.0/3);
            
            //gio [0,23], phut, giay [0, 59]
            int gio = int.Parse(Console.ReadLine());
            int phut = int.Parse(Console.ReadLine()); 
            int giay = int.Parse(Console.ReadLine());
            Console.WriteLine("Gio nhap: {0}:{1}:{2}", gio, phut, giay);
            
            giay++; //ban dau [0, 59] + 1s => [1, 60]
            //3g 2p 15s =>  3g 2p 15s | 3g 2p 59s   => 3g 2p 60s 
            if (giay == 60)
            {
                giay = 0;   phut++; //[0,59] +1p => [1, 60]
                gio += phut / 60;   phut %= 60;
                gio %= 24;  
            }

            Console.WriteLine("Gio sau 1s nua: {0}:{1}:{2}", gio, phut, giay);
            Console.ReadKey();
        }
    }
}
