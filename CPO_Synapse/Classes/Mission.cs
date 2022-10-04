using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPO_Synapse.Classes
{
    public class Mission
    {
        #region Attributs
        private String nom;
        private String description;
        private int nbHeuresPrevues;
        private Dictionary<DateTime, int> releveHoraire;
        private Intervenant intervenant;
        #endregion

        #region Constructeur(s)
        public Mission(String nom, String description, int nbHeuresPrevues, Intervenant intervenant)
        {
            this.nom = nom;
            this.description = description;
            this.nbHeuresPrevues = nbHeuresPrevues;
            this.intervenant = intervenant;
            this.releveHoraire = new Dictionary<DateTime, int>();
        }
        #endregion

        #region Getters
        public String getNom()
        {
            return this.nom;
        }

        public String getDescription()
        {
            return this.description;
        }

        public int getNbHeuresPrevues()
        {
            return this.nbHeuresPrevues;
        }

        public Intervenant getIntervenant()
        {
            return this.intervenant;
        }

        public int getReleveDate(DateTime date)
        {
            return this.releveHoraire[date];
        }
        #endregion

        #region Setters
        private void setNom(String nom)
        {
            this.nom = nom;
        }

        private void setDescription(String description)
        {
            this.description = description;
        }

        private void setNbHeuresPrevues(int nbHeuresPrevues)
        {
            this.nbHeuresPrevues = nbHeuresPrevues;
        }

        private void setReleveHoraire(Dictionary<DateTime, int> releveHoraire)
        {
            this.releveHoraire = releveHoraire;
        }

        private void setIntervenant(Intervenant intervenant)
        {
            this.intervenant = intervenant;
        }
        #endregion

        #region Méthodes
        public void ajoutReleve(DateTime jour, int nbHeures)
        {
            if(nbHeures > 8) { nbHeures = 8; }

            if(this.releveHoraire.ContainsKey(jour))
            {
                nbHeures += this.releveHoraire[jour];
            }
            this.releveHoraire[jour] = nbHeures;
        }
        #endregion

        #region Fonctions
        public int getNbHeuresEffectuees()
        {
            return Enumerable.Sum(this.releveHoraire.Values);
        }
        #endregion
    }
}
