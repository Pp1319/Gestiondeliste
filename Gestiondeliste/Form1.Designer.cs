namespace Gestiondeliste
{
    partial class Liste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Liste));
            this.listBoxCible = new System.Windows.Forms.ListBox();
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.Source = new System.Windows.Forms.Label();
            this.Cible = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAjouterTout = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSupprimerTout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCible
            // 
            this.listBoxCible.FormattingEnabled = true;
            this.listBoxCible.Location = new System.Drawing.Point(384, 101);
            this.listBoxCible.Name = "listBoxCible";
            this.listBoxCible.Size = new System.Drawing.Size(177, 173);
            this.listBoxCible.TabIndex = 2;
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Items.AddRange(new object[] {
            "France",
            "Espagne",
            "Angleterre",
            "Italie",
            "Pays de Galles",
            "Thailande",
            "Malaisie",
            "Chine"});
            this.comboBoxSource.Location = new System.Drawing.Point(60, 101);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSource.TabIndex = 1;
            // 
            // Source
            // 
            this.Source.AutoSize = true;
            this.Source.Location = new System.Drawing.Point(101, 82);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(41, 13);
            this.Source.TabIndex = 3;
            this.Source.Text = "Source";
            // 
            // Cible
            // 
            this.Cible.AutoSize = true;
            this.Cible.Location = new System.Drawing.Point(452, 85);
            this.Cible.Name = "Cible";
            this.Cible.Size = new System.Drawing.Size(30, 13);
            this.Cible.TabIndex = 4;
            this.Cible.Text = "Cible";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(257, 99);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = ">";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnAjouterTout
            // 
            this.btnAjouterTout.Location = new System.Drawing.Point(257, 128);
            this.btnAjouterTout.Name = "btnAjouterTout";
            this.btnAjouterTout.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterTout.TabIndex = 4;
            this.btnAjouterTout.Text = ">>";
            this.btnAjouterTout.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(257, 222);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "<";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerTout
            // 
            this.btnSupprimerTout.Location = new System.Drawing.Point(257, 251);
            this.btnSupprimerTout.Name = "btnSupprimerTout";
            this.btnSupprimerTout.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerTout.TabIndex = 6;
            this.btnSupprimerTout.Text = "<<";
            this.btnSupprimerTout.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(384, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBas
            // 
            this.btnBas.Image = ((System.Drawing.Image)(resources.GetObject("btnBas.Image")));
            this.btnBas.Location = new System.Drawing.Point(486, 280);
            this.btnBas.Name = "btnBas";
            this.btnBas.Size = new System.Drawing.Size(75, 50);
            this.btnBas.TabIndex = 8;
            this.btnBas.UseVisualStyleBackColor = true;
            // 
            // Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 342);
            this.Controls.Add(this.btnBas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSupprimerTout);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouterTout);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.Cible);
            this.Controls.Add(this.Source);
            this.Controls.Add(this.comboBoxSource);
            this.Controls.Add(this.listBoxCible);
            this.Name = "Liste";
            this.Text = "Les listes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCible;
        private System.Windows.Forms.ComboBox comboBoxSource;
        private System.Windows.Forms.Label Source;
        private System.Windows.Forms.Label Cible;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAjouterTout;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnSupprimerTout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBas;
    }
}

