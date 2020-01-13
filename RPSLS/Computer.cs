using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        //Member Variable
        public string name;


        //Constructor
        public Computer()
        {
            

        }
       

        //Member Method

        public override string SelectGesture()
        {
                int result;
                
                List<string> gesture = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
                Random random = new Random();
                result = random.Next(5);
                return gesture[result];           
        }
    }
}
