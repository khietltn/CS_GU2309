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
            TicTacToe game = new TicTacToe();
            game.play();

            Console.ReadKey();
        }
    }
}
