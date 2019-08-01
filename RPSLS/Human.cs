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


        // constructor


        // member methods
        public override void ChooseGesture()
        {
            Console.WriteLine("Choose a gesture");
            gesture = Console.ReadLine();
        }
        public override void ChooseName()
        {
            Console.WriteLine("Choose name");
            name = Console.ReadLine();
        }
    }
}
