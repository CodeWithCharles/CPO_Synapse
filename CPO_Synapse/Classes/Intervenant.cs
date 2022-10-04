using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CPO_Synapse.Classes
{
    public class Intervenant
    {
        #region Attributs
        private String nom;
        private Double tauxHoraire;
        #endregion

        #region Constructeur(s)
        public Intervenant(String nom, Double tauxHoraire)
        {
            this.nom = nom;
            this.tauxHoraire = tauxHoraire;
        }
        #endregion

        #region Getters
        public Double getTauxHoraire()
        {
            return this.tauxHoraire;
        }

        public String getNom()
        {
            return this.nom;
        }
        #endregion

        #region Setters
        private void setTauxHoraire(Double tauxHoraire)
        {
            this.tauxHoraire = tauxHoraire;
        }

        private void setNom(String nom)
        {
            this.nom = nom;
        }
        #endregion
    }
}
