using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi21_DuAn2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TicTacToe game = new TicTacToe();
            //game.play();
            try
            {
                int a = int.Parse(Console.ReadLine());  //0 2   1
                Console.WriteLine(1 / a);
            }
            catch (Exception ex)
            {
                Console.Write("Invalid value.");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
