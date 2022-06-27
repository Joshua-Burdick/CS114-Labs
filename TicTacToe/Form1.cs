using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private Player player = Player.PLAYER_1;
        TicTacToe game;

        public Form1()
        {
            InitializeComponent();
            game = new TicTacToe();
            StatusLabel.Text = $"Status: {(char)player}'s turn!";
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = $"{(char)player}";

            //Checks and validation
            switch(button.Name)
            {
                case "A1":
                    game.setMove(player, 0, 0);
                    break;
                case "A2":
                    game.setMove(player, 0, 1);
                    break;
                case "A3":
                    game.setMove(player, 0, 2);
                    break;
                case "B1":
                    game.setMove(player, 1, 0);
                    break;
                case "B2":
                    game.setMove(player, 1, 1);
                    break;
                case "B3":
                    game.setMove(player, 1, 2);
                    break;
                case "C1":
                    game.setMove(player, 2, 0);
                    break;
                case "C2":
                    game.setMove(player, 2, 1);
                    break;
                case "C3":
                    game.setMove(player, 2, 2);
                    break;
            }

            if(!game.isGameWon())
            {
                if (game.isBoardFull()) StatusLabel.Text = "Status: Game is a draw!";
                else
                {
                    //Switch players
                    if (player == Player.PLAYER_1) player = Player.PLAYER_2;
                    else player = Player.PLAYER_1;

                    StatusLabel.Text = $"Status: {(char)player}'s turn!";

                    button.Enabled = false; //Button can no longer be played
                }
            }
            else
            {
                StatusLabel.Text = $"Status: Player {(char)player} wins!";
                disableAllButtons();
            }
        }

        private void disableAllButtons()
        {
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    c.Enabled = false;
                }
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                    c.Text = "\0";
                }
            }

            player = Player.PLAYER_1;
            game.reset();

            StatusLabel.Text = "Status: ";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
