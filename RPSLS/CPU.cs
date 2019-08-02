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


            // constructor //ctor tab tab


        // member methods
        public override string ChooseGesture()
        {
            gesture = gestureList[GenerateNumber(1,5)];
            return gesture;
        }
        public override string ChooseName()
        {
            Console.WriteLine("Choose computer's name");
            name = Console.ReadLine();
            return name;
        }
        public int GenerateNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
