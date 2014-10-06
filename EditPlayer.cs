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


namespace StadtLandFluss
{
    public partial class EditPlayer : Form
    {
        private string lvName;
        

        public EditPlayer()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lvName = txtName.Text;
            int lvCount;
            Form1.dummyPlayer.playerNickname = lvName;
            if(0 != Form1.playerLista.Count())
            {
                Form1.playerLista.ForEach(delegate(Player elementPlayer)
                {
                   if(lvName.ToLower() == elementPlayer.playerNickname.ToLower())
                   {
                       MessageBox.Show("Dieser Name ist schon vorhanden");
                   }else
                   {
                       this.DialogResult = DialogResult.OK;
                   }
                });
            }else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        internal static void ActiveForm()
        {
            throw new NotImplementedException();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(txtName.Text != "")
            {
                btnOk.Enabled = true;
            }
            else
            {
                btnOk.Enabled = false;
            }
        }
    }
}
