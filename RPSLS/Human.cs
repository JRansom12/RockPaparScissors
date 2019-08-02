using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        // member variables


        // constructorn


        // member methods
        public override string ChooseGesture()
        {
            Console.WriteLine($"{name} choose a gesture: rock, paper, scissors, lizard, or Spock");
            gesture = Console.ReadLine().ToLower().Replace(" ",string.Empty);
            return gesture;
        }
        public override string ChooseName()
        {
            Console.WriteLine("Choose name");
            name = Console.ReadLine();
            return name;
        }
    }
}
