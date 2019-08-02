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
            Console.WriteLine("Rock Paper Scissors Lizard Spock\nThe game of Rock Paper Scissors with additional choices!\nFirst to score " + scoreThreshold + " wins!\nHere are the results for each gesture:\n");
            Console.WriteLine("Rock crushes Scissors\nScissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\n");
        }
        private int GetNumberOfPlayers()
        {
            try
            {
                Console.WriteLine("How many carbon based lifeforms? Enter 1 or 2");
                int numberOfPlayers = int.Parse(Console.ReadLine());
                if (numberOfPlayers == 1 || numberOfPlayers == 2)
                {
                    return numberOfPlayers;
                }
                else
                {
                   return GetNumberOfPlayers();
                }
            }
            catch (FormatException)
            {
                return GetNumberOfPlayers();
            }

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
        public static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        public void CompareGestures()
        {
            if (player1.gesture == "rock" && player2.gesture == "paper")
            {
                player2.score++;
                Console.WriteLine("Paper covers rock. " + player2.name + " scores!");
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
                Console.WriteLine("Bazinga! You've tied. round.");
            }
            else
            {
                Console.WriteLine("Enter an allowed hand gesture.");
            }                
        }

        private void DisplayWinner()
        {
            if (player1.score == scoreThreshold)
            {
                Console.WriteLine(player1.name + " won the game!\n");
            }
            else
            {
                Console.WriteLine(player2.name + " won the game!\n");         
            }
            Console.WriteLine("To play again enter: Big Bang");
            string playAgain = Console.ReadLine().ToLower().Replace(" ",string.Empty);
            if(playAgain == "bigbang")
            {
                RunGame();
            }
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
                ClearLine();
                player2.ChooseGesture();
                ClearLine();
                CompareGestures();
                Console.WriteLine("Current score: " + player1.name + " " + player1.score + " - " + player2.name + " " + player2.score + "\n");
            }
            DisplayWinner();
        }
    }
}
