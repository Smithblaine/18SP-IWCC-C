/* Blaine Smith
 * Prog 10 Due Tuesday, March 27th 2018
 * Matt Clark
 * Program is a game of rock, paper, scissors and will evaluate answers given
 * from computer and player to choose the winner.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BSmith_Prog10
{
    class PlayGame
    {
        static void Main(string[] args)
        {
            string winner = "";
            string name = "";
            int num2 = 0;
            bool player = true;
            bool compU = false;
            bool repeat = false;

            RockPaperPlayer comp = new RockPaperPlayer("Watson");
            Greeting();
            name = GetName();
            RockPaperPlayer user = new RockPaperPlayer(name);
            do
            {
                for (int i = 1; i <= 7; i++)
                {
                    int number = GetNum(player);
                    user.MakeChoice(number);
                    num2 = GetNum(compU);
                    comp.MakeChoice(num2);

                    winner = PlayRound(user, comp);
                    Winner(user, comp, i, winner);
                }
                repeat = RepeatGame();
                user.Wins = 0;
                comp.Wins = 0;
            } while (repeat == true);

        }


        public static void Greeting()
        {
            WriteLine();
            WriteLine("Welcome to the Rock, Paper, Scissors ChampionShip!");
            WriteLine();
            WriteLine("Select a number between 1 and 3\n1 = Rock\n2 = Paper\n3 = Scissors");
            WriteLine("The computer will then select a number from 1 to 3");
            WriteLine("The number from the Player and Computer will then be compaired to determine the winner.");
            WriteLine("Seven (7) rounds will be played and the player with the most wins will become the winner. Ready? Good Luck!");
        }


        public static string GetName()
        {
            Write("\nWhat is your name?  ");
            string userName = ReadLine();
            return userName;
        }


        public static int GetNum(bool player)
        {
            int num = 0;
            if (player == true)
            {
                WriteLine();
                Write("Enter a number 1 - 3:  ");
                num = int.Parse(ReadLine());
                WriteLine();

                while (num < 1 || num > 3)
                {
                    Write("That's not a valid choice. Enter a number 1, 2, or 3: ");
                    num = int.Parse(ReadLine());
                }
            }
            else
            {
                Random comp = new Random();
                num = comp.Next(1, 4);
            }
            return num;
        }


        public static string PlayRound(RockPaperPlayer user, RockPaperPlayer Watson)
        {
            string winner = "";
            string hooman = user.Choice;
            string comp = Watson.Choice;

            //Start ties
            if (hooman == "rock" && comp == "rock")
            {
                winner = ("Round was a Tie\n");
            }
            else if (hooman == "paper" && comp == "paper")
            {
                winner = ("Round was a Tie\n");
            }
            else if (hooman == "scissors" && comp == "scissors")
            {
                winner = ("Round was a Tie\n");
            }
            //End of ties

            //Start player wins
            else if (hooman == "rock" && comp == "scissors")
            {
                winner = string.Format("Winner is: {0}", user.Name);
                user.Wins += 1;
            }
            else if (hooman == "paper" && comp == "rock")
            {
                winner = string.Format("Winner is: {0}", user.Name);
                user.Wins += 1;
            }
            else if (hooman == "scissors" && comp == "paper")
            {
                winner = string.Format("Winner is: {0}", user.Name);
                user.Wins += 1;
            }
            //End player wins

            //sStart comp wins
            else if (hooman == "paper" && comp == "scissors")
            {
                winner = string.Format("Winner is: {0}", Watson.Name);
                Watson.Wins += 1;
            }
            else if (hooman == "scissors" && comp == "rock")
            {
                winner = string.Format("Winner is: {0}", Watson.Name);
                Watson.Wins += 1;
            }
            else
            {
                winner = string.Format("Winner is: {0}", Watson.Name);
                Watson.Wins += 1;
            }
            //End compputer wins
            return winner;
        }


        public static void Winner(RockPaperPlayer user, RockPaperPlayer Watson, int round, string winner)
        {
            WriteLine("Round {0}", round);
            WriteLine(user.Name + " chose " + user.Choice);
            WriteLine(Watson.Name + " chose " + Watson.Choice);
            WriteLine();
            WriteLine(winner);
            WriteLine(user.ToString());
            WriteLine(Watson.ToString());
            WriteLine();

            if (round == 7)
            {
                if (user.Wins > Watson.Wins)
                {
                    WriteLine("Winner of the game is: {0}", user.Name);
                }
                else if (user.Wins < Watson.Wins)
                {
                    WriteLine("Winner of the game is: {0}", Watson.Name);
                }
                else
                {
                    WriteLine("Game was a Tie");
                }
            }
        }



        public static bool RepeatGame()
        {
            WriteLine();
            Write("Would you like to play again?  ");
            string res = ReadLine();

            bool repe = false;

            if (res == "Yes" || res == "yes")
            {
                repe = true;
            }
            return repe;
        }
    }
}
