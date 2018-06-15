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

namespace BSmith_Prog10
{
    class RockPaperPlayer
    {
        private string name;
        private int wins;
        private string choice;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        public string Choice
        {
            get
            {
                return choice;
            }
            set
            {
                choice = value;
            }
        }


        public int Wins
        {
            get
            {
                return wins;
            }
            set
            {
                wins = value;
            }
        }


        public RockPaperPlayer(string nam)
        {
            name = nam;
            wins = 0;
        }


        public void MakeChoice(int num)
        {
            switch (num)
            {
                case 1:
                    choice = "rock";
                    break;
                case 2:
                    choice = "paper";
                    break;
                case 3:
                    choice = "scissors";
                    break;
            }
        }


        public override string ToString()
        {
            return string.Format("Name: {0}\nWins: {1}", name, wins);
        }
    }
}
