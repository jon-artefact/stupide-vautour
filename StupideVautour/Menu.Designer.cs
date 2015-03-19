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
            this.button_2Joueurs = new System.Windows.Forms.Button();
            this.button_3Joueurs = new System.Windows.Forms.Button();
            this.button_4Joueurs = new System.Windows.Forms.Button();
            this.button_5Joueurs = new System.Windows.Forms.Button();
            this.Titre = new System.Windows.Forms.TextBox();
            this.button_Quitter = new System.Windows.Forms.Button();
            this.button_Options = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_2Joueurs
            // 
            this.button_2Joueurs.Location = new System.Drawing.Point(96, 94);
            this.button_2Joueurs.Name = "button_2Joueurs";
            this.button_2Joueurs.Size = new System.Drawing.Size(275, 38);
            this.button_2Joueurs.TabIndex = 0;
            this.button_2Joueurs.Text = "2 Joueurs";
            this.button_2Joueurs.UseVisualStyleBackColor = true;
            this.button_2Joueurs.Click += new System.EventHandler(this.button_2Joueurs_Click);
            // 
            // button_3Joueurs
            // 
            this.button_3Joueurs.Location = new System.Drawing.Point(96, 138);
            this.button_3Joueurs.Name = "button_3Joueurs";
            this.button_3Joueurs.Size = new System.Drawing.Size(275, 38);
            this.button_3Joueurs.TabIndex = 1;
            this.button_3Joueurs.Text = "3 Joueurs";
            this.button_3Joueurs.UseVisualStyleBackColor = true;
            this.button_3Joueurs.Click += new System.EventHandler(this.button_3Joueurs_Click);
            // 
            // button_4Joueurs
            // 
            this.button_4Joueurs.Location = new System.Drawing.Point(96, 182);
            this.button_4Joueurs.Name = "button_4Joueurs";
            this.button_4Joueurs.Size = new System.Drawing.Size(275, 38);
            this.button_4Joueurs.TabIndex = 2;
            this.button_4Joueurs.Text = "4 Joueurs";
            this.button_4Joueurs.UseVisualStyleBackColor = true;
            this.button_4Joueurs.Click += new System.EventHandler(this.button_4Joueurs_Click);
            // 
            // button_5Joueurs
            // 
            this.button_5Joueurs.Location = new System.Drawing.Point(96, 226);
            this.button_5Joueurs.Name = "button_5Joueurs";
            this.button_5Joueurs.Size = new System.Drawing.Size(275, 38);
            this.button_5Joueurs.TabIndex = 3;
            this.button_5Joueurs.Text = "5 Joueurs";
            this.button_5Joueurs.UseVisualStyleBackColor = true;
            this.button_5Joueurs.Click += new System.EventHandler(this.button_5Joueurs_Click);
            // 
            // Titre
            // 
            this.Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.Location = new System.Drawing.Point(196, 24);
            this.Titre.Name = "Titre";
            this.Titre.ReadOnly = true;
            this.Titre.Size = new System.Drawing.Size(82, 35);
            this.Titre.TabIndex = 4;
            this.Titre.Text = "MENU";
            // 
            // button_Quitter
            // 
            this.button_Quitter.Location = new System.Drawing.Point(96, 314);
            this.button_Quitter.Name = "button_Quitter";
            this.button_Quitter.Size = new System.Drawing.Size(275, 38);
            this.button_Quitter.TabIndex = 5;
            this.button_Quitter.Text = "Quitter";
            this.button_Quitter.UseVisualStyleBackColor = true;
            // 
            // button_Options
            // 
            this.button_Options.Location = new System.Drawing.Point(96, 270);
            this.button_Options.Name = "button_Options";
            this.button_Options.Size = new System.Drawing.Size(275, 38);
            this.button_Options.TabIndex = 6;
            this.button_Options.Text = "Options";
            this.button_Options.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 387);
            this.Controls.Add(this.button_Options);
            this.Controls.Add(this.button_Quitter);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.button_5Joueurs);
            this.Controls.Add(this.button_4Joueurs);
            this.Controls.Add(this.button_3Joueurs);
            this.Controls.Add(this.button_2Joueurs);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_2Joueurs;
        private System.Windows.Forms.Button button_3Joueurs;
        private System.Windows.Forms.Button button_4Joueurs;
        private System.Windows.Forms.Button button_5Joueurs;
        private System.Windows.Forms.TextBox Titre;
        private System.Windows.Forms.Button button_Quitter;
        private System.Windows.Forms.Button button_Options;
    }
}