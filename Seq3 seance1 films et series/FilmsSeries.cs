using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seq3_seance1_films_et_series
{
    [SerializableAttribute]
    public abstract class FilmsSeries : IComparable
    {
        protected string titre;
        protected int annee;

        public int CompareTo(object obj)
        {
            return titre.CompareTo(((FilmsSeries)obj).getTitre());
        }

        public FilmsSeries(string titre, int annee)
        {
            this.titre = titre;
            this.annee = annee;
        }

        public string getTitre()
        {
            return titre;
        }

        public int getAnnee()
        {
            return annee;
        }       
    }
    [SerializableAttribute]
    public class Films : FilmsSeries
    {
        private int recette;
        public Films(string titre, int annee, int recette) : base(titre, annee)
        {
            this.recette = recette;
        }    
        public int getRecette()
        {
            return recette;
        }
        public override string ToString()
        {
            return base.annee + "  " +  base.titre + ",  " + "recette : " + recette; 
        }
    }
    [SerializableAttribute]
    public class Series : FilmsSeries
    {
        private int nbEpisodes;
        public Series(string titre, int annee, int nbEpisode) : base(titre, annee)
        {
            this.nbEpisodes = nbEpisode;
        }
        public int getNbSeries()
        {
            return nbEpisodes;
        }
        public override string ToString()
        {
            return base.annee + "  " + base.titre + ",  " + "nombre episodes : " + nbEpisodes;
        }

    }

}
