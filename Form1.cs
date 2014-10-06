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
using System.Diagnostics;
using System.Web;

namespace StadtLandFluss
{
    public partial class Form1 : Form
    {
        int playerCount = 0;
        public static List<Player> playerLista = new List<Player>();
        bool firstTime = true;
        Stopwatch timer1 = new Stopwatch();
        public static Player dummyPlayer = new Player("dummy");

        




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
            timer1.Restart();
            timer2.Start();
            round++;
            lblRound.Text = "Runde: " + round;
            start_Buchstabe = RandomLetter.GetLetter();
            lblBuchstabe.Text = "Buchstabe: "+Char.ToString(start_Buchstabe);

            txtStart.Enabled = false;
            txtEnd.Enabled = false;
            Stats.Enabled = false;

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
            Stats.Enabled = true;
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
            playerLista.ForEach(delegate(Player elementPlayerA)
            {
                elementPlayerA.points = 0;
                elementPlayerA.points += checkEntry(txtStadt, elementPlayerA);
                elementPlayerA.playerTxtStadt = txtStadt.Text;
                elementPlayerA.points += checkEntry(txtLand, elementPlayerA);
                elementPlayerA.playerTxtLand = txtLand.Text;
                elementPlayerA.points += checkEntry(txtFluss, elementPlayerA);
                elementPlayerA.playerTxtFluss = txtFluss.Text;

                elementPlayerA.allPoints += elementPlayerA.points;
                elementPlayerA.fillStats();
            });
            
            

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
            timer1.Stop();
            timer2.Stop();
            countPoints();
            playerLista.ForEach(delegate(Player elementPlayer)
            {
                MessageBox.Show("Spieler: " + elementPlayer.playerNickname + "\n Punkte von dieser Runde: " + elementPlayer.points + "\n Punkte Gesamt: " + elementPlayer.allPoints);
            });
            
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

            //for (int i2 = 0; i2 < 2; i2++)
            //{
            //    string lvShortName = "Ruben" + i2.ToString();
            //    playerAll[i2] = new Player(lvShortName);
            //}
        
            
        }

        private void Stats_Click(object sender, EventArgs e)
        {
            playerLista.ForEach(delegate(Player elementPlayer)
            {
                elementPlayer.displayStats(round);
            });
        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPlayer lfEditPlayer = new EditPlayer();


            if (lfEditPlayer.ShowDialog() == DialogResult.OK)
            {
                //playerLista.Add(dummyPlayer)

                playerLista.Add(new Player(dummyPlayer.playerNickname)
                {
                });
                playerCount++;
                lblPlayer.Text = "Spieler Anzahl: " + playerCount;
                if (firstTime == true)
                {
                    txtStart.Enabled = true;
                    firstTime = false;
                }
            }



            

            //Player fluffPlayer = new Player("fluff");
            //Player fluffPlayer = playerLista.Items;
            //MessageBox("Neuer Spieler:"+fluffPlayer.playerNickname);
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            updateLabel();
        }

        private void updateLabel()
        {
            TimeSpan ts = timer1.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            lblTimer.Text = "Zeit: "+elapsedTime;
        }



        
    }
}
