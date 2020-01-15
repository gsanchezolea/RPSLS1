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

            
        //Constructor
        public Computer()
        {
            name = "Computer";
        }

        //Member Method
        public int GenerataRandomNumber()
        {
            Random random = new Random();
            return random.Next(5);
        }
        public override string SelectGesture()
        {
            int randomNumberGenerated;
            string result;           
            randomNumberGenerated = GenerataRandomNumber();
            result = gestures[randomNumberGenerated];
            Console.WriteLine("Computer has selected " + result);
            return result;
        }

    }
}
