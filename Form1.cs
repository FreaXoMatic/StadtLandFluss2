using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StadtLandFluss
{
    public partial class Form1 : Form
    {
        int playerCount = 0;
     
        Player[] playerAll = new Player[2];



        public Form1()
        {
            InitializeComponent(); 
        }

        int round = 0;
        char start_Buchstabe;
        int points;

        private void txtStart_Click(object sender, EventArgs e)
        {
            startGame();
        }
        
        static class RandomLetter
        {
            static Random _random = new Random();
            public static char GetLetter()
            {
                int num = _random.Next(0, 26);
                char let = (char)('a' + num);
                return let;
            }
        }

        public void startGame()
        {
            round++;
            start_Buchstabe = RandomLetter.GetLetter();
            lblBuchstabe.Text = "Buchstabe: "+Char.ToString(start_Buchstabe);

            txtStart.Enabled = false;
            txtEnd.Enabled = false;

            txtFluss.Enabled = true;
            txtLand.Enabled = true;
            txtStadt.Enabled = true;
            txtStadt.Text = "";
            txtLand.Text = "";
            txtFluss.Text = "";
            
        }

        public void endGame()
        {
            
            lblBuchstabe.Text = "Buchstabe: ?";
            txtStart.Enabled = true;
            txtEnd.Enabled = false;

            txtFluss.Enabled = false;
            txtLand.Enabled = false;
            txtStadt.Enabled = false;

            txtFluss.BackColor = Color.White;
            txtLand.BackColor = Color.White;
            txtStadt.BackColor = Color.White;

            
        }

        public void countPoints()
        {

            //foreach(Player lvPlayer in playerArray)
            //{
            //    lvPlayer.points += checkEntry(txtStadt);
            //    lvPlayer.points += checkEntry(txtLand);
            //    lvPlayer.points += checkEntry(txtFluss);
            //}
           foreach(Player elementPlayer in playerAll)
           {
               elementPlayer.points = 0;
               elementPlayer.points += checkEntry(txtStadt,elementPlayer);
               elementPlayer.playerTxtStadt = txtStadt.Text;
               elementPlayer.points += checkEntry(txtLand,elementPlayer);
               elementPlayer.playerTxTLand = txtLand.Text;
               elementPlayer.points += checkEntry(txtFluss,elementPlayer);
               elementPlayer.playerTxTFluss = txtFluss.Text;

               elementPlayer.allPoints += elementPlayer.points;
               elementPlayer.fillStats(round);
           }
            
            

        }

        private int checkEntry(TextBox textField,Player loPlayer)
        {
            int lvPoints;
            if (textField.Text.Substring(0, 1).ToUpper() == Char.ToString(start_Buchstabe).ToUpper())
            {
                
                DialogResult Result = MessageBox.Show("Echtes Wort? \nStadt: " + textField.Text, "Bewertung für Spieler: "+loPlayer.playerNickname, MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
              
                    textField.BackColor = Color.Green;
                    lvPoints = 10;
                    return lvPoints;
                }
                else
                {
                    textField.BackColor = Color.Red;
                    lvPoints = 0;
                    return lvPoints;
                }


            }
            else
            {
                textField.BackColor = Color.Red;
                lvPoints = 0;
                return lvPoints;
            }
        }

        private void txtEnd_Click(object sender, EventArgs e)
        {
            
            countPoints();
            foreach(Player elementPlayer in playerAll )
            {
                MessageBox.Show("Spieler: " + elementPlayer.playerNickname + "\n Punkte von dieser Runde: " + elementPlayer.points+"\n Punkte Gesamt: "+ elementPlayer.allPoints);
            }
            
            endGame();
        }



        private void EnableSend(object sender, EventArgs e)
        {
           if (string.IsNullOrEmpty(txtFluss.Text) || string.IsNullOrEmpty(txtStadt.Text) || string.IsNullOrEmpty(txtLand.Text) )
           {
               txtEnd.Enabled = false;
           }
           else
           {
               txtEnd.Enabled = true;
           }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i2 = 0; i2 < 2; i2++)
            {
                string lvShortName = "Ruben" + i2.ToString();
                playerAll[i2] = new Player(lvShortName);
            }
        
            
        }

        private void Stats_Click(object sender, EventArgs e)
        {
            foreach (Player elementPlayer in playerAll)
            {
                elementPlayer.displayStats();  
            }
        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Player Player3 = new Player("Ruben2");
            
        }


        
    }
}
