using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Tile
    {
        private TeamEnum.Team tileTeam;
        private int tileX;
        private int tileY;
        public Tile(int tileY, int tileX, TeamEnum.Team tileTeam)
        {
            this.tileTeam = tileTeam;
            this.tileY = tileY;
            this.tileX = tileX;
        }

        public int getTileX() { return tileX; }
        public int getTileY() { return tileY; }
        public TeamEnum.Team getTileTeam() { return tileTeam; }




    }
}
