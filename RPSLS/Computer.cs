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

        }

        //Member Method

        public int RandomizedInteger()
        {            
            Random random = new Random();
            return random.Next(0, 6);            
        }        
    }
}
