namespace StupideVautour
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button_2Joueurs = new System.Windows.Forms.Button();
            this.button_3Joueurs = new System.Windows.Forms.Button();
            this.button_4Joueurs = new System.Windows.Forms.Button();
            this.button_5Joueurs = new System.Windows.Forms.Button();
            this.button_Quitter = new System.Windows.Forms.Button();
            this.difficulty = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // button_2Joueurs
            // 
            this.button_2Joueurs.BackColor = System.Drawing.Color.Transparent;
            this.button_2Joueurs.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_2Joueurs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_2Joueurs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button_2Joueurs, "button_2Joueurs");
            this.button_2Joueurs.ForeColor = System.Drawing.Color.Gold;
            this.button_2Joueurs.Name = "button_2Joueurs";
            this.button_2Joueurs.UseVisualStyleBackColor = true;
            this.button_2Joueurs.Click += new System.EventHandler(this.button_2Joueurs_Click);
            // 
            // button_3Joueurs
            // 
            this.button_3Joueurs.BackColor = System.Drawing.Color.Transparent;
            this.button_3Joueurs.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_3Joueurs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_3Joueurs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button_3Joueurs, "button_3Joueurs");
            this.button_3Joueurs.ForeColor = System.Drawing.Color.Gold;
            this.button_3Joueurs.Name = "button_3Joueurs";
            this.button_3Joueurs.UseVisualStyleBackColor = true;
            this.button_3Joueurs.Click += new System.EventHandler(this.button_3Joueurs_Click);
            // 
            // button_4Joueurs
            // 
            this.button_4Joueurs.BackColor = System.Drawing.Color.Transparent;
            this.button_4Joueurs.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_4Joueurs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_4Joueurs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button_4Joueurs, "button_4Joueurs");
            this.button_4Joueurs.ForeColor = System.Drawing.Color.Gold;
            this.button_4Joueurs.Name = "button_4Joueurs";
            this.button_4Joueurs.UseVisualStyleBackColor = true;
            this.button_4Joueurs.Click += new System.EventHandler(this.button_4Joueurs_Click);
            // 
            // button_5Joueurs
            // 
            this.button_5Joueurs.BackColor = System.Drawing.Color.Transparent;
            this.button_5Joueurs.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_5Joueurs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_5Joueurs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button_5Joueurs, "button_5Joueurs");
            this.button_5Joueurs.ForeColor = System.Drawing.Color.Gold;
            this.button_5Joueurs.Name = "button_5Joueurs";
            this.button_5Joueurs.UseVisualStyleBackColor = true;
            this.button_5Joueurs.Click += new System.EventHandler(this.button_5Joueurs_Click);
            // 
            // button_Quitter
            // 
            this.button_Quitter.BackColor = System.Drawing.Color.Transparent;
            this.button_Quitter.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Quitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Quitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button_Quitter, "button_Quitter");
            this.button_Quitter.ForeColor = System.Drawing.Color.Gold;
            this.button_Quitter.Name = "button_Quitter";
            this.button_Quitter.UseVisualStyleBackColor = true;
            this.button_Quitter.Click += new System.EventHandler(this.quitter);
            // 
            // difficulty
            // 
            this.difficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(170)))), ((int)(((byte)(211)))));
            resources.ApplyResources(this.difficulty, "difficulty");
            this.difficulty.ForeColor = System.Drawing.Color.Gold;
            this.difficulty.Items.Add(resources.GetString("difficulty.Items"));
            this.difficulty.Items.Add(resources.GetString("difficulty.Items1"));
            this.difficulty.Items.Add(resources.GetString("difficulty.Items2"));
            this.difficulty.Items.Add(resources.GetString("difficulty.Items3"));
            this.difficulty.Name = "difficulty";
            this.difficulty.ReadOnly = true;
            this.difficulty.SelectedItemChanged += new System.EventHandler(this.difficulty_SelectedItemChanged);
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StupideVautour.Properties.Resources.Verso;
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.button_Quitter);
            this.Controls.Add(this.button_5Joueurs);
            this.Controls.Add(this.button_4Joueurs);
            this.Controls.Add(this.button_3Joueurs);
            this.Controls.Add(this.button_2Joueurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_2Joueurs;
        private System.Windows.Forms.Button button_3Joueurs;
        private System.Windows.Forms.Button button_4Joueurs;
        private System.Windows.Forms.Button button_5Joueurs;
        private System.Windows.Forms.Button button_Quitter;
        private System.Windows.Forms.DomainUpDown difficulty;
    }
}