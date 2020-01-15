﻿using System;
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
            List<string> gesture = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            randomNumberGenerated = GenerataRandomNumber();
            result = gesture[randomNumberGenerated];
            Console.WriteLine("Computer has selected " + result);
            return result;
        }

    }
}
