using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        // member variables
        public Player player1;
        public Player player2;
        public Hand hand1;
        public Hand hand2;
        public int winThreshold;

        // constructor
        public Game()
        {
            player1 = new Player(1);
            player2 = new Player(2);
            hand1 = new Hand("HandChoice");
            hand2 = new Hand("HandChoice");
            winThreshold = 2;
        }


        // member methods

    }
}
