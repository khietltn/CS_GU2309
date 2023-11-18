using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi21_DuAn2
{
    class TicTacToe
    {
        public TicTacToe()
        {

        }

        public void play()
        {
            int moveCounter = 0;    //xác định người chơi chẵn= player1 / lẻ= player2
            Board gameBoard = new Board();
            Player playerX = new Player('X');
            Player playerO = new Player('O');
            Player currentPlayer = playerX; //xác định lượt chơi đầu tiên
            bool play = true;           //thiết menu số 1-9 chơi
            while (play)
            {
                gameBoard.printBoard();     //in bàn cờ
                Console.WriteLine("Player {0} enter the field in which you want to put the number:", currentPlayer.Sign);    //chờ ng dùng nhập dữ liệu
                try
                {
                   
                    //xác định lượt và số number
                    int turn = currentPlayer.takeTurn();    //nhập dữ liệu
                    if (!gameBoard.putMark(currentPlayer.Sign, turn))
                        xulySai();
                    else
                    {
                        gameBoard.clearBoard();
                        moveCounter++;  //tối đa lên tới 9
                        //kiểm tra đã thắng chưa
                        if (currentPlayer.checkWin(gameBoard))
                        {
                            Console.WriteLine("Player {0} won!", currentPlayer.Sign);
                            gameBoard.printBoard();
                            play = false;
                        }
                        //kiểm tra có hòa chưa
                        else if (moveCounter == 9)
                        {
                            Console.WriteLine("Draw!");
                            gameBoard.printBoard();
                            play = false;
                        }
                        //ko thắng , ko hòa -> đi tiếp
                        currentPlayer = (moveCounter % 2 == 0) ? playerX : playerO;
                    }
                }catch (Exception ex)
                {
                    xulySai();
                }
            }
        }

        private void xulySai()
        {
            Console.WriteLine("Invalid input. Please enter number between 1- 9!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
