using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StadtLandFluss
{
  

    public class Player
    {
        public string playerNickname;
        public string playerTxtStadt;
        public string playerTxtLand;
        public string playerTxtFluss;
        public string[,] statsList;


        public int points;
        public int allPoints;
        
        public Player(string nn)
        {
            playerNickname = nn;
        }

        public void fillStats(int round)
        {
            this.statsList = new string[3, 2]{{ "Stadt1", this.playerTxtStadt },{"Land1",this.playerTxtLand},{"Fluss1",this.playerTxtFluss}};
           
            //this.statsList[1] = new string[]{"HI"};
            //this.statsList[round][1] = "Land";
            //this.statsList[round][2] = "Fluss";
        }

        public void displayStats()
        {
            int lvRoundCount = 1;
            MessageBox.Show("Spieler:" + this.playerNickname + "\nRunde: " + lvRoundCount + "\n" + this.statsList[0, 0] + ": " + this.statsList[0, 1] + "\n" + this.statsList[1, 0] + ": " + this.statsList[1, 1] + "\n" + "\n" + this.statsList[2, 0] + ": " + this.statsList[2, 1] + "\n");
        }


    


    }
}
