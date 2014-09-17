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
            this.SuspendLayout();
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(13, 195);
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
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stadt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 81);
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
            this.lblBuchstabe.Location = new System.Drawing.Point(16, 27);
            this.lblBuchstabe.Name = "lblBuchstabe";
            this.lblBuchstabe.Size = new System.Drawing.Size(61, 13);
            this.lblBuchstabe.TabIndex = 8;
            this.lblBuchstabe.Text = "Buchstabe:";
            // 
            // Stats
            // 
            this.Stats.Location = new System.Drawing.Point(13, 246);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(75, 23);
            this.Stats.TabIndex = 9;
            this.Stats.Text = "Stats";
            this.Stats.UseVisualStyleBackColor = true;
            this.Stats.Click += new System.EventHandler(this.Stats_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 390);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

