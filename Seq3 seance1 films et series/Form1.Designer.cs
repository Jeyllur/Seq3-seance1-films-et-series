
namespace Seq3_seance1_films_et_series
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
            this.rdFilm = new System.Windows.Forms.RadioButton();
            this.rdSerie = new System.Windows.Forms.RadioButton();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.lblRecette = new System.Windows.Forms.Label();
            this.lblNbEpisodes = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.txtRecette = new System.Windows.Forms.TextBox();
            this.txtNbEpisodes = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lstFilmSeries = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rdFilm
            // 
            this.rdFilm.AutoSize = true;
            this.rdFilm.Checked = true;
            this.rdFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdFilm.Location = new System.Drawing.Point(12, 12);
            this.rdFilm.Name = "rdFilm";
            this.rdFilm.Size = new System.Drawing.Size(51, 20);
            this.rdFilm.TabIndex = 0;
            this.rdFilm.TabStop = true;
            this.rdFilm.Text = "Film";
            this.rdFilm.UseVisualStyleBackColor = true;
            this.rdFilm.CheckedChanged += new System.EventHandler(this.rdFilm_CheckedChanged);
            // 
            // rdSerie
            // 
            this.rdSerie.AutoSize = true;
            this.rdSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdSerie.Location = new System.Drawing.Point(82, 12);
            this.rdSerie.Name = "rdSerie";
            this.rdSerie.Size = new System.Drawing.Size(58, 20);
            this.rdSerie.TabIndex = 1;
            this.rdSerie.Text = "Serie";
            this.rdSerie.UseVisualStyleBackColor = true;
            this.rdSerie.CheckedChanged += new System.EventHandler(this.rdSerie_CheckedChanged);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitre.Location = new System.Drawing.Point(12, 49);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(35, 16);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Titre";
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnnee.Location = new System.Drawing.Point(12, 78);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(47, 16);
            this.lblAnnee.TabIndex = 3;
            this.lblAnnee.Text = "Annee";
            // 
            // lblRecette
            // 
            this.lblRecette.AutoSize = true;
            this.lblRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRecette.Location = new System.Drawing.Point(12, 109);
            this.lblRecette.Name = "lblRecette";
            this.lblRecette.Size = new System.Drawing.Size(55, 16);
            this.lblRecette.TabIndex = 4;
            this.lblRecette.Text = "Recette";
            // 
            // lblNbEpisodes
            // 
            this.lblNbEpisodes.AutoSize = true;
            this.lblNbEpisodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNbEpisodes.Location = new System.Drawing.Point(12, 141);
            this.lblNbEpisodes.Name = "lblNbEpisodes";
            this.lblNbEpisodes.Size = new System.Drawing.Size(86, 16);
            this.lblNbEpisodes.TabIndex = 5;
            this.lblNbEpisodes.Text = "Nb épisodes";
            // 
            // txtTitre
            // 
            this.txtTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTitre.Location = new System.Drawing.Point(120, 48);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(415, 22);
            this.txtTitre.TabIndex = 6;
            // 
            // txtAnnee
            // 
            this.txtAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAnnee.Location = new System.Drawing.Point(120, 78);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(131, 22);
            this.txtAnnee.TabIndex = 7;
            // 
            // txtRecette
            // 
            this.txtRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRecette.Location = new System.Drawing.Point(120, 109);
            this.txtRecette.Name = "txtRecette";
            this.txtRecette.Size = new System.Drawing.Size(131, 22);
            this.txtRecette.TabIndex = 8;
            // 
            // txtNbEpisodes
            // 
            this.txtNbEpisodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNbEpisodes.Location = new System.Drawing.Point(120, 141);
            this.txtNbEpisodes.Name = "txtNbEpisodes";
            this.txtNbEpisodes.Size = new System.Drawing.Size(131, 22);
            this.txtNbEpisodes.TabIndex = 9;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 169);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(523, 24);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lstFilmSeries
            // 
            this.lstFilmSeries.FormattingEnabled = true;
            this.lstFilmSeries.Location = new System.Drawing.Point(12, 199);
            this.lstFilmSeries.Name = "lstFilmSeries";
            this.lstFilmSeries.Size = new System.Drawing.Size(523, 225);
            this.lstFilmSeries.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 436);
            this.Controls.Add(this.lstFilmSeries);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtNbEpisodes);
            this.Controls.Add(this.txtRecette);
            this.Controls.Add(this.txtAnnee);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.lblNbEpisodes);
            this.Controls.Add(this.lblRecette);
            this.Controls.Add(this.lblAnnee);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.rdSerie);
            this.Controls.Add(this.rdFilm);
            this.Name = "Form1";
            this.Text = "Films et series";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdFilm;
        private System.Windows.Forms.RadioButton rdSerie;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.Label lblRecette;
        private System.Windows.Forms.Label lblNbEpisodes;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.TextBox txtRecette;
        private System.Windows.Forms.TextBox txtNbEpisodes;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ListBox lstFilmSeries;
    }
}

