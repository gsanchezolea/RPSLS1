using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        //Member Variable
        public string name;
        public int score;



        //Constructor
        public Game(string name, int score)
        {
            this.name = name;
            this.score = score;

            
        }


        //Member Method
        public void StartGame()
        {

        }

        public void MainMenu()
        {
            
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock");
            Console.WriteLine("1. Player vs Player \n2. Player vs Computer");
            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Console.WriteLine("You have selected Player vs Player");
                    InstantiatePVP();
                    PlayerVSPlayer();
                    break;

                case 2:
                    Console.WriteLine("You have selected Player vs Computer");
                    InstatiatePVC();
                    PlayerVSComputer();
                    break;

                default:
                    Console.WriteLine("You have selected an incorrect key, please try again..");
                    break;
            }
        }

        public void PlayerVSPlayer()
        {

        }
        public void InstantiatePVP()
        {
            
            Console.WriteLine("Type a Name for Player 1");
            string result1 = Console.ReadLine();
            Human human1 = new Human("Player 1");
            Console.WriteLine("Type a Name for Player 2");
            string result2 = Console.ReadLine();
            Human human2 = new Human("Player 2");           
        }
        public void PlayerVSComputer()
        {

        }
        public void InstatiatePVC()
        {

        }

        //Sandbox

        public void TestGame()
        {
            while(player.)
        }
    }
}
