using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    internal class Player
    {
        private int playerTurn = 0;
        private const int playerMaxTurn = 2;
        private TeamEnum.Team playerTeam;
        private Tile[] playerTileArray = new Tile[3];

        public Player(TeamEnum.Team team)
        {
            this.playerTeam = team;
        }
        public void setPlayerTurn()
        {
            if (this.playerTurn < playerMaxTurn)
            {
                this.playerTurn++;
            }
            else
            {
                this.playerTurn = 0;
            }
        }

        public int getPlayerTurn() { return playerTurn; }

        public int getPlayerMaxTurn() { return playerMaxTurn; }

        public TeamEnum.Team getPlayerTeam() { return playerTeam; }


        public Tile[] getPlayerTileArray() { return playerTileArray; }
        
        public void setPlayerTileArray(Tile tile)
        {
            playerTileArray.SetValue(tile, this.playerTurn);
        }

       


    }
}
