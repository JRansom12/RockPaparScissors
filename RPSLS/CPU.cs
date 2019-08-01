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
        public override string ChooseGesture()
        {


            return gesture;
        }
        public override string ChooseName()
        {
            Console.WriteLine("Choose computer's name");
            name = Console.ReadLine();
            return name;
        }
        public int GenerateNumber()
        {
            int generatedNumber = rng.Next(0, 5);
            return generatedNumber;
        }
}
}
