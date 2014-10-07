namespace StadtLandFluss
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtStart = new System.Windows.Forms.Button();
            this.txtStadt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFluss = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.Button();
            this.lblBuchstabe = new System.Windows.Forms.Label();
            this.Stats = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStart
            // 
            this.txtStart.Enabled = false;
            this.txtStart.Location = new System.Drawing.Point(13, 126);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(75, 23);
            this.txtStart.TabIndex = 0;
            this.txtStart.Text = "Start Game";
            this.txtStart.UseVisualStyleBackColor = true;
            this.txtStart.Click += new System.EventHandler(this.txtStart_Click);
            // 
            // txtStadt
            // 
            this.txtStadt.Enabled = false;
            this.txtStadt.Location = new System.Drawing.Point(13, 100);
            this.txtStadt.Name = "txtStadt";
            this.txtStadt.Size = new System.Drawing.Size(100, 20);
            this.txtStadt.TabIndex = 1;
            this.txtStadt.TextChanged += new System.EventHandler(this.EnableSend);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stadt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Land";
            // 
            // txtLand
            // 
            this.txtLand.Enabled = false;
            this.txtLand.Location = new System.Drawing.Point(119, 100);
            this.txtLand.Name = "txtLand";
            this.txtLand.Size = new System.Drawing.Size(100, 20);
            this.txtLand.TabIndex = 3;
            this.txtLand.TextChanged += new System.EventHandler(this.EnableSend);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fluss";
            // 
            // txtFluss
            // 
            this.txtFluss.Enabled = false;
            this.txtFluss.Location = new System.Drawing.Point(225, 100);
            this.txtFluss.Name = "txtFluss";
            this.txtFluss.Size = new System.Drawing.Size(100, 20);
            this.txtFluss.TabIndex = 5;
            this.txtFluss.TextChanged += new System.EventHandler(this.EnableSend);
            // 
            // txtEnd
            // 
            this.txtEnd.Enabled = false;
            this.txtEnd.Location = new System.Drawing.Point(340, 98);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(75, 23);
            this.txtEnd.TabIndex = 7;
            this.txtEnd.Text = "Absenden";
            this.txtEnd.UseVisualStyleBackColor = true;
            this.txtEnd.Click += new System.EventHandler(this.txtEnd_Click);
            // 
            // lblBuchstabe
            // 
            this.lblBuchstabe.AutoSize = true;
            this.lblBuchstabe.Location = new System.Drawing.Point(10, 27);
            this.lblBuchstabe.Name = "lblBuchstabe";
            this.lblBuchstabe.Size = new System.Drawing.Size(61, 13);
            this.lblBuchstabe.TabIndex = 8;
            this.lblBuchstabe.Text = "Buchstabe:";
            // 
            // Stats
            // 
            this.Stats.Enabled = false;
            this.Stats.Location = new System.Drawing.Point(13, 155);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(75, 23);
            this.Stats.TabIndex = 9;
            this.Stats.Text = "Stats";
            this.Stats.UseVisualStyleBackColor = true;
            this.Stats.Click += new System.EventHandler(this.Stats_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.chatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(432, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.playerToolStripMenuItem.Text = "Player";
            this.playerToolStripMenuItem.Click += new System.EventHandler(this.playerToolStripMenuItem_Click);
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(10, 40);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(45, 13);
            this.lblRound.TabIndex = 11;
            this.lblRound.Text = "Runde: ";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(116, 27);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(77, 13);
            this.lblPlayer.TabIndex = 12;
            this.lblPlayer.Text = "Spieler Anzahl:";
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(StadtLandFluss.Player);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(116, 40);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(30, 13);
            this.lblTimer.TabIndex = 13;
            this.lblTimer.Text = "Time";
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.chatToolStripMenuItem.Text = "Chat";
            this.chatToolStripMenuItem.Click += new System.EventHandler(this.chatToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 191);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.lblBuchstabe);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFluss);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStadt);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtStart;
        private System.Windows.Forms.TextBox txtStadt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFluss;
        private System.Windows.Forms.Button txtEnd;
        private System.Windows.Forms.Label lblBuchstabe;
        private System.Windows.Forms.Button Stats;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
    }
}

