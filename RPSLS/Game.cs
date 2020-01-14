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
        public int player1Points;
        public int player2Points;   
        public int gameModeSelected;
        public Player player1;
        public Player player2;
        public string player1Selection;
        public string player2Selection;



        //Constructor
        public Game()
        {
            
            
           
        }

        //Member Method
        public void StartGame()
        {
            MainMenu();
            InstatiatePlayers();
            GameGestureSelection();
            PointAssigner();
            CheckRoundWinner();     

        }

        public void MainMenu()
        {

            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock");
            Console.WriteLine("Select 1 for Human vs Human \nSelect 2 for Human vs Computer \nSelect 3 for Instructions");
            
            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Console.WriteLine("You have selected Player vs Player");
                    break;

                case 2:
                    Console.WriteLine("You have selected Player vs Computer");
                    break;

                case 3:
                    Instructions();
                    MainMenu();
                    return;

                default:
                    Console.WriteLine("You have selected an incorrect key, please try again..");
                    MainMenu();
                    return;
            }
            gameModeSelected = selection;
        }
        public void InstatiatePlayers()
        {
            if (gameModeSelected == 1)
            {
                player1 = new Human("Player 1"); //Test User Input
                player2 = new Human("Player 2");
            }
            else if (gameModeSelected == 2)
            {
                player1 = new Human("Player");
                player2 = new Computer();
            }
            else
            {
                Console.WriteLine(" ");
            }
        }
        public void Instructions()
        {
            Console.WriteLine("Instructions:");
            Console.WriteLine($"Scissors cuts Paper \nPaper covers Rock \nScissors cuts Paper \nRock crushes Lizard \nLizard poisons Spock \nSpock smashes Scissors" +
                             $"\nScissors decapitates Lizard \nLizard eats Paper \nPaper disproves Spock \nSpock vaporizes Rock \nand as always... \nRock crushes Scissors " +
                             $"\n - Sheldon(BBT) \nPress enter to go back to the Main Menu");
            Console.ReadLine();
        
        }
        public void GameGestureSelection()
        {
            Console.WriteLine("Player 1");
            player1Selection = player1.SelectGesture();
            Console.WriteLine("Player 2");
            player2Selection = player2.SelectGesture();
        }
        public void PointAssigner()
        {
            if (player1Selection == "Rock")
            {
                    //It Can Beat
                if (player2Selection  == "Lizard" || player2Selection == "Scissors")
                {
                    player1Points++;
                }
                else if (player2Selection  == "Spock" || player2Selection == "Paper")
                {
                    player2Points++;
                }
                else
                {
                    Console.WriteLine("Its a Tie");
                }                    
            }

            if (player1Selection == "Paper")
            {
                if (player2Selection == "Spock" || player2Selection == "Rock")
                {
                    player1Points++;
                }
                else if (player2Selection == "Scissors" || player2Selection == "Lizard")
                {
                    player2Points++;
                }
                else
                {
                    Console.WriteLine("Its a Tie");
                }
            }

            if (player1Selection == "Scissors")
            {
                if (player2Selection == "Lizard" || player2Selection == "Paper")
                {
                    player1Points++;
                }
                else if (player2Selection == "Rock" || player2Selection == "Spock")
                {
                    player2Points++;
                }
                else
                {
                    Console.WriteLine("Its a Tie");
                }
            }

            if (player1Selection == "Lizard")
            {
                if (player2Selection == "Spock" || player2Selection == "Paper")
                {
                    player1Points++;
                }
                else if (player2Selection == "Rock" || player2Selection == "Scissors")
                {
                    player2Points++;
                }
                else
                {
                    Console.WriteLine("Its a Tie");
                }
            }

            if (player1Selection == "Spock")
            {
                if (player2Selection == "Scissors" || player2Selection == "Rock")
                {
                    player1Points++;
                }
                else if (player2Selection == "Lizard" || player2Selection == "Paper")
                {
                    player2Points++;
                }
                else
                {
                    Console.WriteLine("Its a Tie");
                }
            }

        }
        public void CheckRoundWinner()
        {
            if (player1Points == 2)
            {
                Console.WriteLine("Player 1 is the Winner!");
            }
            else if (player2Points == 2)
            {
                Console.WriteLine("Player 2 is the Winner!");
            }
            else
            {
                Console.WriteLine("Error 414");
            }
        }   
    }
}
