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
            InstantiatePlayers();
            while (TotalScoreChecker(player1Points, player2Points))
            {
                GameGestureSelection();
                PointAssigner();
            }
            ClearScore();
            GameOver();
        }
        public void MainMenu()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock");
            Console.WriteLine("Select 1 for Human vs Human \nSelect 2 for Human vs Computer \nSelect 3 for Instructions \nSelect 4 for Scoring");
            int selection = 0;
            int.TryParse(Console.ReadLine(), out selection);
           
            switch (selection)
            {
                case 1:
                    Console.WriteLine("You have selected Human vs Human, \nPlayer 1 is Human \nPlayer 2 is Human");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("You have selected Human vs Computer \nPlayer 1 is Human \nPlayer 2 is a Computer");
                    Console.ReadLine();
                    break;

                case 3:
                    Instructions();
                    MainMenu();
                    return;

                case 4:
                    Scoring();
                    MainMenu();
                    return;

                default:
                    Console.WriteLine("You have selected an incorrect key, please try again..");
                    MainMenu();
                    return;
            }
            gameModeSelected = selection;
        }
        public void InstantiatePlayers()
        {
            if (gameModeSelected == 1)
            {
                player1 = new Human("Player 1");
                player2 = new Human("Player 2");
            }
            else if (gameModeSelected == 2)
            {
                player1 = new Human("Human");
                player2 = new Computer();
            }
            else
            {
                Console.WriteLine("Error 414");
            }
        }
        public void Instructions()
        {
            Console.WriteLine("Instructions: \n");
            Console.WriteLine($"Scissors cuts Paper \nPaper covers Rock \nScissors cuts Paper \nRock crushes Lizard \nLizard poisons Spock \nSpock smashes Scissors" +
                             $"\nScissors decapitates Lizard \nLizard eats Paper \nPaper disproves Spock \nSpock vaporizes Rock \nand as always... \nRock crushes Scissors " +
                             $"\n - Sheldon(BBT)");
            PressEnterToContinue();
        }
        public void Scoring()
        {
            Console.WriteLine("Scoring:");
            Console.WriteLine($"This game is setup with \na best of 3 scoring system, \nin other words if you win \na total of 2 out of 3 matches \nyou win the game " +
                              $"\nPress enter to go back to the Main Menu");
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
            if (player1Selection == player2Selection)
            {
                Console.WriteLine("Its a Tie");
            }
            else if (player1Selection == "Rock")
            {                
                if (player2Selection == "Lizard" || player2Selection == "Scissors")
                {
                    Player1Wins();
                }
                else
                {
                    Player2Wins();
                }                    
            }
            else if (player1Selection == "Paper")
            {
                if (player2Selection == "Rock" || player2Selection == "Spock")
                {
                    Player1Wins();
                }
                else
                {
                    Player2Wins();
                }
            }
            else if (player1Selection == "Scissors")
            {
                if (player2Selection == "Paper" || player2Selection == "Lizard")
                {
                    Player1Wins();
                }
                else
                {
                    Player2Wins();
                }
            }
            else if (player1Selection == "Lizard")
            {
                if (player2Selection == "Spock" || player2Selection == "Paper")
                {
                    Player1Wins();
                }
                else
                {
                    Player2Wins();
                }
            }
            else
            {
                if (player2Selection == "Rock" || player2Selection == "Scissors")
                {
                    Player1Wins();
                }
                else
                {
                    Player2Wins();
                }
            }
        }        
        public void GameOver()
        {
            Console.WriteLine("GAME OVER");
            Console.ReadLine();
        }      
        public bool TotalScoreChecker(int parameter1, int parameter2) 
        {
            player1Points = parameter1;
            player2Points = parameter2;
            if (player1Points == 2)
            {
                Console.WriteLine("Player 1 You Win This Game");
                PressEnterToContinue();
                return false;
            }
            else if (player2Points == 2)
            {
                Console.WriteLine("Player 2 You Win This Game");
                PressEnterToContinue();
                return false;
            }
            else
            {
                Console.WriteLine("New Match Begins");
                PressEnterToContinue();
                return true;
            }
        }
        public void ClearScore()
        {
            if (player2Points >= 1 || player2Points >= 1)              
                {
                    player1Points = 0;
                    player2Points = 0;
                }
        }
        public void Player1Wins()
        {
            Console.WriteLine("Player 1 Wins this Match");
            PressEnterToContinue();
            player1Points++;
        }
        public void Player2Wins()
        {
            Console.WriteLine("Player 2 Wins this Match");
            PressEnterToContinue();
            player2Points++;
        }
        public void PressEnterToContinue()
        {
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
        }
    }
}
