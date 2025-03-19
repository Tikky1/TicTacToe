using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class CheckGameFinish
    {


        public static TeamEnum.Team isGameFinished(Board board)
        {
            Tile[,] tiles = board.getboardTileArray();



            if (tiles[0, 0] != null && tiles[1, 1] != null && tiles[2, 2] != null)
            {
                if (tiles[0, 0].getTileTeam() == tiles[1, 1].getTileTeam() &&
                                    tiles[0, 0].getTileTeam() == tiles[2, 2].getTileTeam())
                {
                    return tiles[0, 0].getTileTeam();
                }
            }
            if (tiles[0, 2] != null && tiles[1, 1] != null && tiles[2, 0] != null)
            {
                if (tiles[0, 2].getTileTeam() == tiles[1, 1].getTileTeam() &&
                         tiles[2, 0].getTileTeam() == tiles[1, 1].getTileTeam())
                {
                    return tiles[0, 2].getTileTeam();
                }

            }



            for (int i = 0; i < 3; i++)
            {
                if (tiles[i, 0] != null && tiles[i, 1] != null && tiles[i, 2] != null)
                {
                    if (tiles[i, 0].getTileTeam() == tiles[i, 1].getTileTeam() &&
                    tiles[i, 0].getTileTeam() == tiles[i, 2].getTileTeam())
                    {
                        return tiles[i, 0].getTileTeam();
                    }
                }
                else if (tiles[0, i] != null && tiles[1, i] != null && tiles[2, i] != null)
                {
                    if (tiles[0, i].getTileTeam() == tiles[1, i].getTileTeam() &&
                         tiles[0, i].getTileTeam() == tiles[2, i].getTileTeam())
                    {
                        return tiles[0, i].getTileTeam();
                    }
                }


            }
            return TeamEnum.Team.None;



        }
    }
}
