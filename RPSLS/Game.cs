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
        private void DisplayRules()
        {
            Console.WriteLine("Rock Paper Scissors Lizard Spock\nThe game of Rock Paper Scissors with additional choices!\n");
        }
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
        public void CompareGestures()
        {
            if (player1.gesture == "rock" && player2.gesture == "paper")
            {
                player2.score++;
                Console.WriteLine("Paper covers rock. " + player1.name + " scores!");
            }
            else if (player1.gesture == "rock" && player2.gesture == "scissors")
            {
                player1.score++;
                Console.WriteLine("Rock crushes scissors. " + player1.name + " scores!");
            }
            else if (player1.gesture == "rock" && player2.gesture == "lizard")
            {
                player1.score++;
                Console.WriteLine("Rock crushes lizard. " + player1.name + " scores!");
            }
            else if (player1.gesture == "rock" && player2.gesture == "spock")
            {
                player2.score++;
                Console.WriteLine("Spock vaporizes rock. " + player2.name + " scores!");
            }
            else if (player1.gesture == "paper" && player2.gesture == "scissors")
            {
                player2.score++;
                Console.WriteLine("Scissors cuts paper. " + player2.name + " scores!");
            }
            else if (player1.gesture == "paper" && player2.gesture == "lizard")
            {
                player2.score++;
                Console.WriteLine("Lizard eats paper. " + player2.name + " scores!");
            }
            else if (player1.gesture == "paper" && player2.gesture == "spock")
            {
                player1.score++;
                Console.WriteLine("Paper disproves Spock. " + player1.name + " scores!");
            }
            else if (player1.gesture == "scissors" && player2.gesture == "lizard")
            {
                player1.score++;
                Console.WriteLine("Scissors decapitates lizard. " + player1.name + " scores!");
            }
            else if (player1.gesture == "scissors" && player2.gesture == "spock")
            {
                player2.score++;
                Console.WriteLine("Spock smashes scissors. " + player2.name + " scores!");
            }
            else if (player1.gesture == "lizard" && player2.gesture == "spock")
            {
                player1.score++;
                Console.WriteLine("Lizard poisons Spock. " + player1.name + " scores!");
            }
            else if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("Bazinga! Redo round.");
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
