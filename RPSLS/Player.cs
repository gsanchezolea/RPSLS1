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






        //Member Method
        public abstract string SelectGesture();
        
       
    }
}
