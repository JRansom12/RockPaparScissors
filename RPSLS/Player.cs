using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        // member variables
        public int playerNumber;
        public int winCounter;

        // constructor
        public Player(int PlayerNumber)
        {
            playerNumber = PlayerNumber;
            winCounter = 0;
        }
        // member methods
        public string showHand()
        {
            Console.WriteLine("3... 2... 1... Show your hand! Enter Rock, Paper, Scissors, Lizard, or Spock.");
            string input = Console.ReadLine();
            return input;
        }

    }
}
