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
        Board board = new Board();
        private bool isPlayerXTurn = true;
        private TeamEnum.Team team = TeamEnum.Team.X;
        private Player playerX = new Player(TeamEnum.Team.X);
        private Player playerO = new Player(TeamEnum.Team.O);



        public Form1()
        {
            InitializeComponent();
        }

        private void PressedBtn(int y, int x)
        {

            bool isCanPerform;
            Tile tile = new Tile(y, x, team);

            if (isPlayerXTurn)
            {
                isCanPerform = board.setboardTileArray(playerX, tile);

            }
            else
            {
                isCanPerform = board.setboardTileArray(playerO, tile);

            }




            if (isCanPerform)
            {
                if (isPlayerXTurn)
                {
                    playerX.setPlayerTileArray(tile);
                    playerX.setPlayerTurn();

                }
                else
                {
                    playerO.setPlayerTileArray(tile);
                    playerO.setPlayerTurn();

                }
                changeTeam();
                isPlayerXTurn = !isPlayerXTurn;
            }


            


        }

        



        private void changeTeam()
        {
            if (team == TeamEnum.Team.X)
            {
                team = TeamEnum.Team.O;
            }
            else
            {
                team = TeamEnum.Team.X;
            }
        }
        private void button_Click(object sender, EventArgs e)
        {


            Control clickedControl = sender as Control;

            if (clickedControl != null)
            {
                TableLayoutPanelCellPosition position = tableLayoutPanel1.GetCellPosition(clickedControl);
                int x = position.Row;
                int y = position.Column;


                PressedBtn(y, x);
                updateBoard();
            }

            TeamEnum.Team winner = CheckGameFinish.isGameFinished(board);
            if (winner == TeamEnum.Team.X)
            {
                gameFinishedLabel.Text = "Player 1 won";
                return;
            }
            else if (winner == TeamEnum.Team.O)
            {
                gameFinishedLabel.Text = "Player 2 won";
                return;
            }



        }




        private void updateBoard()
        {

            for (int t = 0; t < board.getboardSize(); t++)
            {
                for (int k = 0; k < board.getboardSize(); k++)
                {
                    if (board.getboardTileArray()[t, k] != null)
                    {
                        tableLayoutPanel1.GetControlFromPosition(t, k).Text = board.getboardTileArray()[t, k].getTileTeam().ToString(); ;
                    }
                    else
                    {
                        tableLayoutPanel1.GetControlFromPosition(t, k).Text = " ";
                    }
                }
            }
        }



    }
}
