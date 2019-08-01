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
        public int scoreThreshold;
        // constructor ctor
        public Game()
        {
            scoreThreshold = 2;
        }


        // member methods
        private void DisplayRules()
        {
            Console.WriteLine("Rock Paper Scissors Lizard Spock\n", "The game of Rock Paper Scissors with additional choices!\n");
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
            else if (player1.gesture == "paper" && player2.gesture == "rock")
            {
                player1.score++;
                Console.WriteLine("Paper covers rock. " + player1.name + " scores!");
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
            else if (player1.gesture == "scissors" && player2.gesture == "rock")
            {
                player2.score++;
                Console.WriteLine("Rock crushes scissors. " + player2.name + " scores!");
            }
            else if (player1.gesture == "scissors" && player2.gesture == "paper")
            {
                player1.score++;
                Console.WriteLine("Scissors cut paper. " + player1.name + " scores!");
            }
            else if (player1.gesture == "lizard" && player2.gesture == "spock")
            {
                player1.score++;
                Console.WriteLine("Lizard poisons Spock. " + player1.name + " scores!");
            }
            else if (player1.gesture == "lizard" && player2.gesture == "rock")
            {
                player2.score++;
                Console.WriteLine("Rock crushes lizard. " + player2.name + " scores!");
            }
            else if (player1.gesture == "lizard" && player2.gesture == "paper")
            {
                player1.score++;
                Console.WriteLine("Lizard eats paper. " + player1.name + " scores!");
            }
            else if (player1.gesture == "lizard" && player2.gesture == "scissors")
            {
                player2.score++;
                Console.WriteLine("Scissors decapitate lizard. " + player2.name + " scores!");
            }
            else if (player1.gesture == "spock" && player2.gesture == "lizard")
            {
                player2.score++;
                Console.WriteLine("Lizard poisons Spock. " + player2.name + " scores!");
            }
            else if (player1.gesture == "spock" && player2.gesture == "rock")
            {
                player1.score++;
                Console.WriteLine("Spock vaporizes rock. " + player1.name + " scores!");
            }
            else if (player1.gesture == "spock" && player2.gesture == "paper")
            {
                player2.score++;
                Console.WriteLine("Paper disproves Spock. " + player2.name + " scores!");
            }
            else if (player1.gesture == "spock" && player2.gesture == "scissors")
            {
                player1.score++;
                Console.WriteLine("Spock smashes scissors. " + player1.name + " scores!");
            }
            else if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("Bazinga! Redo round.");
            }
            else
            {
                Console.WriteLine("Enter an allowed hand gesture.");
            }
                
        }

        public void DisplayWinner()
        {
            if (player1.score == scoreThreshold)
            {
                Console.WriteLine(player1.name + " won the game!\n");
            }
            else
            {
                Console.WriteLine(player2.name + " won the game!\n");
            }
            Console.WriteLine("Game over!");
        }

        public void RunGame()  //Runs each of the methods for the algorithm
        {
            DisplayRules();
            int numberOfPlayers = GetNumberOfPlayers();
            SetUpPlayers(numberOfPlayers);
            player1.ChooseName();
            player2.ChooseName();
            
            while(player1.score < scoreThreshold && player2.score < scoreThreshold){
                player1.ChooseGesture();
                player2.ChooseGesture();
                CompareGestures();
                Console.WriteLine("Current score: " + player1.score + "-" + player2.score + "\n");
            }

            DisplayWinner();
        }
    }
}
