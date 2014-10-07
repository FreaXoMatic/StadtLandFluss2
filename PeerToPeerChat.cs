using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StadtLandFluss
{
    public partial class PeerToPeerChat : Form
    {
        string userName = "";

        public string UserName
        {
            get { return userName; }
        }

        public PeerToPeerChat()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(LoginForm_FormClosing);
            btnOK.Click += new EventHandler(btnOK_Click);
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            userName = tbUserName.Text.Trim();

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Bitte einen Namen mit bis zu 32 Zeichen wählen");
                return;
            }

            this.FormClosing -= LoginForm_FormClosing;
            this.Close();
        }

        void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            userName = "";
        }

        private void PeerToPeerChat_Load(object sender, EventArgs e)
        {

        }

    }
}
