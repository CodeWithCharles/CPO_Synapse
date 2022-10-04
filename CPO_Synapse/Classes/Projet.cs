using System;
using System.Collections.Generic;
using System.Text;

namespace CPO_Synapse.Classes
{
    public class Projet
    {
        #region Attributs
        private String nom;
        private DateTime debut;
        private DateTime fin;
        private Double prixFactureMO;
        private List<Mission> missions;
        #endregion

        #region Constructeur(s)
        public Projet(String nom, DateTime debut, DateTime fin, Double prixFactureMO)
        {
            this.nom = nom;
            this.debut = debut;
            this.fin = fin;
            this.prixFactureMO = prixFactureMO;
            this.missions = new List<Mission>();
        }
        #endregion

        #region Getters
        public String getNom()
        {
            return this.nom;
        }

        public DateTime getDebut()
        {
            return this.debut;
        }

        public DateTime getFin()
        {
            return this.fin;
        }

        public Double getPrixFactureMO()
        {
            return this.prixFactureMO;
        }

        public List<Mission> getMissions()
        {
            return this.missions;
        }
        #endregion

        #region Setters
        private void setNom(String nom)
        {
            this.nom = nom;
        }

        private void setDebut(DateTime debut)
        {
            this.debut = debut;
        }

        private void setFin(DateTime fin)
        {
            this.fin = fin;
        }

        private void setPrixFactureMO(Double prixFactureMO)
        {
            this.prixFactureMO = prixFactureMO;
        }

        private void setMissions(List<Mission> missions)
        {
            this.missions = missions;
        }
        #endregion

        #region Méthodes
        public void ajoutMission(Mission mission)
        {
            this.missions.Add(mission);
        }
        #endregion

        #region Fonctions

        #region Privées
        private Double cumulCoutMO()
        {
            Double coutTotal = 0;
            Double taux = 0;

            foreach (Mission mission in this.missions)
            {
                taux = mission.getIntervenant().getTauxHoraire();
                coutTotal += mission.getNbHeuresEffectuees() * taux;
            }

            return coutTotal;
        }
        #endregion

        #region Publiques
        public Double margeBruteCourante()
        {
            return this.prixFactureMO - this.cumulCoutMO();
        }

        public int nbHeuresTotalesEffectuees()
        {
            int nbHeures = 0;
            foreach(Mission mission in this.missions)
            {
                nbHeures += mission.getNbHeuresEffectuees();
            }
            return nbHeures;
        }
        #endregion

        #endregion
    }
}
