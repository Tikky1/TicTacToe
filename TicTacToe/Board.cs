using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    internal class Board
    {
        private const int boardSize = 3;

        private Tile[,] boardTileArray = new Tile[boardSize, boardSize];

        public Board()
        {
        }

        public Tile[,] getboardTileArray()
        {
            return boardTileArray;
        }
        public bool setboardTileArray(Player player, Tile newTile)
        {
            if (boardTileArray[newTile.getTileY(),newTile.getTileX()] != null)
            {
                return false;
            }
            int count = player.getPlayerTurn();
            Tile prevTile = player.getPlayerTileArray()[count];
            if (prevTile != null)
            {
                
                boardTileArray[prevTile.getTileY(), prevTile.getTileX()] = null;
            }
            
            boardTileArray[newTile.getTileY(),newTile.getTileX()] = newTile;
            return true;
        }

        public int getboardSize() {return boardSize;}



    }
}
