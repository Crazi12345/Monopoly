using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{

   
    internal class GameHandler
    {
        private List<Player> playerList = new List<Player>();
        private int gameID;
        private Player currentPlayer;
        public GameHandler(List<Player> playerList, int gameID, Player currentPlayer)
        {
            this.playerList = playerList;
            this.gameID = gameID;   
            this.currentPlayer = currentPlayer;
        }

        public void setCurrentPlayer(Player player)
        {
            currentPlayer = player;
        }
        public Player getPlayer()
        {
            return currentPlayer;
        }
    }
}
