using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //Member Variable
        public string name;
        public int score;
        public string gesture;

        public List<string> gestures;

        //Constructor (Class is abstract, therefore this class does not need to be insantiated)
        public Player()
        {
            gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        }
        //Member Method
        public abstract string SelectGesture();
    }
}
