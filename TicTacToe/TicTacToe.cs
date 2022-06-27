using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TicTacToe
{
    public enum Player { PLAYER_1 = 'X', PLAYER_2 = 'O' };

    internal class TicTacToe
    {
        private const int BOARD_SIZE = 3;
        private int count = 0;
        private char[,] board;
        private int row, col;

        public TicTacToe()
        {
            board = new char[BOARD_SIZE, BOARD_SIZE];
            reset();
        }

        public bool isBoardFull()
        {
            // Presumes if it gets to this point there isn't a winner (since win is check first)
            // so if the board is full it's auto draw.
            if (count == 9) return true;
            else return false;
        }

        public bool isGameWon()
        {
            // Instead of brute force checking every row, col, and diagonal every time, the presumption that the
            // previous move didn't cause a win and only the row, col, and diagonals (depending on the move made)
            // of the current move need to be checked.
            if ((board[row, 0] == board[row, 1]) && (board[row, 0] == board[row, 2])) // Rows
            {
                return true;
            }
            else if ((board[0, col] == board[1, col]) && (board[0, col] == board[2, col])) // Cols
            {
                return true;
            }
            // Diagonals
            else if ((board[0, 0] != '\0') && (board[0, 0] == board[1, 1]) && (board[0, 0] == board[2, 2]))
            {
                return true;
            }
            else if ((board[0, 2] != '\0') && (board[0, 2] == board[1, 1]) && (board[0, 2] == board[2, 0]))
            {
                return true;
            }

            return false;
        }

        public void setMove(Player player, int row, int col)
        {
            this.row = row;
            this.col = col;
            board[row, col] = (char)player;
            count++;
        }

        public void reset()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = '\0';
                }
            }
        }
    }
}
