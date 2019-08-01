using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class CPU : Player
    {
        // member variables
        public Random rng;


        // constructor //ctor tab tab



        // member methods
        public int GenerateNumber()
        {
            int generatedNumber = rng.Next(1, 6);
            return generatedNumber;
        }
        public override string ChooseGesture()
        {
            gesture = gestureList[GenerateNumber()];
            return gesture;
        }
        public override string ChooseName()
        {
            name = "Computer";
            return name;
        }
    }
}
