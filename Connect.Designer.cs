namespace StadtLandFluss
{
    partial class Connect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNameLobby = new System.Windows.Forms.Label();
            this.txtNameLobby = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtIpLobby = new System.Windows.Forms.TextBox();
            this.lblIPLobby = new System.Windows.Forms.Label();
            this.btnConnectLobby = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameLobby
            // 
            this.lblNameLobby.AutoSize = true;
            this.lblNameLobby.Location = new System.Drawing.Point(13, 37);
            this.lblNameLobby.Name = "lblNameLobby";
            this.lblNameLobby.Size = new System.Drawing.Size(35, 13);
            this.lblNameLobby.TabIndex = 0;
            this.lblNameLobby.Text = "Name";
            // 
            // txtNameLobby
            // 
            this.txtNameLobby.Location = new System.Drawing.Point(16, 54);
            this.txtNameLobby.Name = "txtNameLobby";
            this.txtNameLobby.Size = new System.Drawing.Size(158, 20);
            this.txtNameLobby.TabIndex = 1;
            // 
            // txtIpLobby
            // 
            this.txtIpLobby.Location = new System.Drawing.Point(16, 97);
            this.txtIpLobby.Name = "txtIpLobby";
            this.txtIpLobby.Size = new System.Drawing.Size(158, 20);
            this.txtIpLobby.TabIndex = 3;
            // 
            // lblIPLobby
            // 
            this.lblIPLobby.AutoSize = true;
            this.lblIPLobby.Location = new System.Drawing.Point(13, 80);
            this.lblIPLobby.Name = "lblIPLobby";
            this.lblIPLobby.Size = new System.Drawing.Size(17, 13);
            this.lblIPLobby.TabIndex = 2;
            this.lblIPLobby.Text = "IP";
            // 
            // btnConnectLobby
            // 
            this.btnConnectLobby.Location = new System.Drawing.Point(16, 124);
            this.btnConnectLobby.Name = "btnConnectLobby";
            this.btnConnectLobby.Size = new System.Drawing.Size(158, 23);
            this.btnConnectLobby.TabIndex = 4;
            this.btnConnectLobby.Text = "Verbinden";
            this.btnConnectLobby.UseVisualStyleBackColor = true;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 167);
            this.Controls.Add(this.btnConnectLobby);
            this.Controls.Add(this.txtIpLobby);
            this.Controls.Add(this.lblIPLobby);
            this.Controls.Add(this.txtNameLobby);
            this.Controls.Add(this.lblNameLobby);
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameLobby;
        private System.Windows.Forms.TextBox txtNameLobby;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtIpLobby;
        private System.Windows.Forms.Label lblIPLobby;
        private System.Windows.Forms.Button btnConnectLobby;
    }
}