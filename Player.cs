﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace StadtLandFluss
{
  

    public class Player
    {
        public string playerNickname { get; set; }
        public string playerTxtStadt;
        public string playerTxtLand;
        public string playerTxtFluss;
        public string[,] statsList;
        public List<StatsList> statsList2 = new List<StatsList>();
        public int points;
        public int allPoints;
        public string ip;
        
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
            StatsList loStatsList;
            lvRoundCount--;    
            for (int ia = 0; ia <= lvRoundCount;ia++)
            {                
                loStatsList = this.statsList2[ia];
                string lvStadt = loStatsList.stadtClass;
                string lvLand = loStatsList.landClass;
                string lvFluss = loStatsList.flussClass;

                MessageBox.Show("Spieler:" + this.playerNickname + "\nRunde: " + ia + "\nStadt: " + lvStadt + "\nLand: " + lvLand + "\nFluss: " + lvFluss + "\n");
            }

          
        }

        public void setIp()
        {
           // string str = "";
            //System.Net.Dns.GetHostName();
            //IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(str);
            //IPAddress[] addr = ipEntry.AddressList;
            //
            //this.ip = addr[addr.Length - 1].ToString(); 

            this.ip = Dns.GetHostEntry(Dns.GetHostName()).AddressList[2].ToString();
        }


    


    }
}
