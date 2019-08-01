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
        Player player1;
        Player player2;

        // constructor


        // member methods
        private int GetNumberOfPlayers()
        {
            Console.WriteLine("How many players?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }
        private void SetUpPlayers(int numberOfPlayers)
        {
            if(numberOfPlayers == 1)
            {
                player1 = new Human();
                player2 = new CPU();
            }
            else
            {
                player1 = new Human();
                player2 = new Human();
            }
        }
        public void RunGame()  //Runs each of the methods for the algorithm
        {
            int numberOfPlayers = GetNumberOfPlayers();
            SetUpPlayers(numberOfPlayers);
            //While loop here
            player1.ChooseGesture();
            player2.ChooseGesture();
        }
    }
}
