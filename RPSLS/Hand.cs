using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Hand
    {
        // member variables
        public string handChoice;
        public Random rng;
        public string[] handArray = new string[5];

        // constructor
        public Hand(string HandChoice)
        {
            handChoice = HandChoice;
        }

        //Hand Rock = new Hand("rock");
        //Hand Paper = new Hand("paper");
        //Hand Scissors = new Hand("scissors");
        //Hand Lizard = new Hand("lizard");
        //Hand Spock = new Hand("spock");

        // member methods

        public void AddHandArray()
        {
            handArray[0] = "rock";
            handArray[1] = "paper";
            handArray[2] = "scissors";
            handArray[3] = "lizard";
            handArray[4] = "spock";

            foreach (string in handArray)
            {
                Console.WriteLine();
            }
        }

        public int GenerateNumber()
        {
            int generatedNumber = rng.Next(1, 5+1);
            return generatedNumber;
        }
    }
}
