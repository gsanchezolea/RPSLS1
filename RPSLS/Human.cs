using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        //Member Variable
        
       

        //Constructor
        public Human(string name)
        {
            this.name = name;
            
        }

        //Member Method

        public override string SelectGesture()
        {
            int gestureindex;
            gestureindex = 5;

            Console.WriteLine("Please select a Gesture");
            Console.WriteLine("(i.e. 1. Rock is 1");
            Console.WriteLine("1. Rock \n2. Paper \n3. Scissors \n4. Lizard \n5. Spock");
            int result = int.Parse(Console.ReadLine());

            switch (result)
            {
                case 1:
                    Console.WriteLine("You have selected Rock");
                    gestureindex = 0;
                    break;

                case 2:
                    Console.WriteLine("You have selected Paper");
                    gestureindex = 1;
                    break;

                case 3:
                    Console.WriteLine("You have selected Scissor");
                    gestureindex = 2;
                    break;

                case 4:
                    Console.WriteLine("You have selected Lizard");
                    gestureindex = 3;
                    break;

                case 5:
                    Console.WriteLine("You have selected Spock");
                    gestureindex = 4;
                    break;

                default:
                    Console.WriteLine("You have selected an incorrect key, please try again..");
                    SelectGesture();
                    break;
            }

            List<string> gesture = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            return gesture[gestureindex];
        } 

    }
}
