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
        public List<StatsList> statsList2 = new List<StatsList>();
        
  


        public int points;
        public int allPoints;
        
        public Player(string nn)
        {
            playerNickname = nn;
        }

        public void fillStats()
        {
            //this.statsList = new string[3, 2]{{ "Stadt1", this.playerTxtStadt },{"Land1",this.playerTxtLand},{"Fluss1",this.playerTxtFluss}};
            this.statsList2.Add(new StatsList
            {
                stadtClass = this.playerTxtStadt,
                landClass = this.playerTxtLand,
                flussClass = this.playerTxtFluss
            });
            //this.statsList[1] = new string[]{"HI"};
            //this.statsList[round][1] = "Land";
            //this.statsList[round][2] = "Fluss";
        }

        public void displayStats(int lvRoundCount)
        {
            for (int ia = 0; ia >= 1-lvRoundCount;ia++)
            {
                StatsList loStatsList = this.statsList2[ia];
                string lvStadt = loStatsList.stadtClass;
                string lvLand = loStatsList.landClass;
                string lvFluss = loStatsList.flussClass;

                MessageBox.Show("Spieler:" + this.playerNickname + "\nRunde: " + ia + "\nStadt: " + lvStadt + "\nLand: " + lvLand + "\nFluss: " + lvFluss + "\n");
            }

          
        }


    


    }
}
