using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seq3_seance1_films_et_series
{
    public partial class Form1 : Form
    {
        List<FilmsSeries> lesFilmsSeries = new List<FilmsSeries>();
        private String nomFichier = "Sauvegarde des films et series";
        public Form1()
        {
            InitializeComponent();
        }

        private void MajLstFilmsSeries()
        {
            lesFilmsSeries.Sort();
            lstFilmSeries.Items.Clear();
            foreach(FilmsSeries filmsSeries in lesFilmsSeries)
            {
                lstFilmSeries.Items.Add(filmsSeries.ToString());
            }
            Serialise.Sauve(nomFichier, lesFilmsSeries);
        }

        private void RdButton()
        {
            txtRecette.Enabled = rdFilm.Checked;
            txtNbEpisodes.Enabled = !rdFilm.Checked;
        }

        private void rdFilm_CheckedChanged(object sender, EventArgs e)
        {
            RdButton();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FilmsSeries unFilmSerie;
            if(rdFilm.Checked)
            {
                unFilmSerie = new Films(txtTitre.Text, int.Parse(txtAnnee.Text), int.Parse(txtRecette.Text));               
            }
            else
            {
                unFilmSerie = new Series(txtTitre.Text, int.Parse(txtAnnee.Text), int.Parse(txtNbEpisodes.Text));
            }
            lesFilmsSeries.Add(unFilmSerie);
            MajLstFilmsSeries();
        }

        private void rdSerie_CheckedChanged(object sender, EventArgs e)
        {
            RdButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RdButton();
            Object obj = Serialise.Recup(nomFichier);
            if(obj != null)
            {
                lesFilmsSeries = (List<FilmsSeries>)obj;
                MajLstFilmsSeries();
            }
        }
    }
}
