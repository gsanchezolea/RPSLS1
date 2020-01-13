using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player : Game
    {
        //Member Variable
        public string name;
        public string gesture;

        //Constructor
        public Player()
        {

        }

        //Member Method
        public void GestureAssignment()
        {
            List<string> gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }         
        
        //Returns a value of 0-5, indicating the position of the input on a list.
        public void GestureSelection()
        {
            double gestureindex;
            gestureindex = 0;

            Console.WriteLine("Please Select a Gesture");
            Console.WriteLine("1) Rock \n2) Paper \n 3) Scissors \n 4) Lizard \n 5) Spock");
            double gesture = double.Parse(Console.ReadLine());

            switch (gesture)
            {
                case 1: 
                    Console.WriteLine();
                    gestureindex = 0;
                    break;

                case 2: 
                    Console.WriteLine();
                    gestureindex = 1;
                    break;

                case 3:
                    Console.WriteLine();
                    gestureindex = 2;
                    break;

                case 4:
                    Console.WriteLine();
                    gestureindex = 3;
                    break;

                case 5:
                    Console.WriteLine();
                    gestureindex = 4;
                    break;

                default:
                    Console.WriteLine();
                    break;
            }
            
        }
       
    }
}
