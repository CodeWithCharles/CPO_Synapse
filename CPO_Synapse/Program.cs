using CPO_Synapse.Classes;
using System;
using System.Diagnostics;

namespace CPO_Synapse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mission mission = new Mission("TaskScheduler", "Description de la mission TeskScheduler", 15, new Intervenant("Thierry Peuple", 15.4));
            DateTime date = new DateTime(2022, 09, 13);
            mission.ajoutReleve(date, 10);
            mission.ajoutReleve(date, 5);
            date = new DateTime(2022, 04, 19);
            mission.ajoutReleve(date, 6);

            Projet projet = new Projet("TaskManagment", new DateTime(2022, 10, 01), new DateTime(2022, 10, 05), 1000);

            projet.ajoutMission(mission);

            Debug.Assert(21 == projet.nbHeuresTotalesEffectuees(), "Erreur", "Erreur encore");
            Debug.Assert(19 == projet.nbHeuresTotalesEffectuees());
        }
    }
}
