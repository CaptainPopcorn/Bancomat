namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CbXDevise = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxBEntiers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxBCentimes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnValider = new System.Windows.Forms.Button();
            this.BtnEffacer = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 212);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 115);
            this.textBox1.TabIndex = 0;
            // 
            // CbXDevise
            // 
            this.CbXDevise.FormattingEnabled = true;
            this.CbXDevise.Location = new System.Drawing.Point(12, 68);
            this.CbXDevise.Name = "CbXDevise";
            this.CbXDevise.Size = new System.Drawing.Size(157, 21);
            this.CbXDevise.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Devise";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxBEntiers
            // 
            this.TxBEntiers.Location = new System.Drawing.Point(15, 112);
            this.TxBEntiers.Name = "TxBEntiers";
            this.TxBEntiers.Size = new System.Drawing.Size(154, 20);
            this.TxBEntiers.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Entiers";
            // 
            // TxBCentimes
            // 
            this.TxBCentimes.Location = new System.Drawing.Point(15, 157);
            this.TxBCentimes.Name = "TxBCentimes";
            this.TxBCentimes.Size = new System.Drawing.Size(154, 20);
            this.TxBCentimes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Centimes";
            // 
            // BtnValider
            // 
            this.BtnValider.Location = new System.Drawing.Point(12, 183);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(157, 23);
            this.BtnValider.TabIndex = 7;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = true;
            // 
            // BtnEffacer
            // 
            this.BtnEffacer.Location = new System.Drawing.Point(13, 348);
            this.BtnEffacer.Name = "BtnEffacer";
            this.BtnEffacer.Size = new System.Drawing.Size(75, 23);
            this.BtnEffacer.TabIndex = 8;
            this.BtnEffacer.Text = "Effacer";
            this.BtnEffacer.UseVisualStyleBackColor = true;
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(94, 348);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(75, 23);
            this.BtnQuitter.TabIndex = 9;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(189, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposDeToolStripMenuItem,
            this.aideToolStripMenuItem1});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.aideToolStripMenuItem.Text = "?";
            // 
            // aProposDeToolStripMenuItem
            // 
            this.aProposDeToolStripMenuItem.Name = "aProposDeToolStripMenuItem";
            this.aProposDeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aProposDeToolStripMenuItem.Text = "A propos de...";
            // 
            // aideToolStripMenuItem1
            // 
            this.aideToolStripMenuItem1.Name = "aideToolStripMenuItem1";
            this.aideToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aideToolStripMenuItem1.Text = "Aide";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 401);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnEffacer);
            this.Controls.Add(this.BtnValider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxBCentimes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxBEntiers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbXDevise);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox CbXDevise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxBEntiers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxBCentimes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.Button BtnEffacer;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem1;
    }
}

