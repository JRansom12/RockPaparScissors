using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        // member variables
        public string gesture;
        public int score;
        public string name;
        public List<string> gestureList;

        // constructor
        public Player()
        {
            gestureList = new List<string>();
            gestureList.Add("rock");
            gestureList.Add("paper");
            gestureList.Add("scissors");
            gestureList.Add("lizard");
            gestureList.Add("spock");
        }

        // member methods
        public abstract string ChooseGesture();
        public abstract string ChooseName();
    }
}
