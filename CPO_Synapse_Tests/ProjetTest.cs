using CPO_Synapse.Classes;
using System;
using Xunit;

namespace CPO_Synapse_Tests
{
    public class ProjetTest
    {
        [Fact]
        public void TestCreation()
        {
            Projet projet = new Projet("TaskManagment", new DateTime(2022, 10, 01), new DateTime(2022, 10, 05), 1000);
            Assert.NotNull(projet);
        }

        [Fact]
        public void TestNom()
        {
            Projet projet = new Projet("TaskManagment", new DateTime(2022, 10, 01), new DateTime(2022, 10, 05), 1000);
            Assert.Equal("TaskManagment", projet.getNom());
        }

        [Fact]
        public void TestDebut()
        {
            Projet projet = new Projet("TaskManagment", new DateTime(2022, 10, 01), new DateTime(2022, 10, 05), 1000);
            DateTime debut = new DateTime(2022, 10, 01);
            Assert.Equal(debut, projet.getDebut());
        }

        [Fact]
        public void TestFin()
        {
            Projet projet = new Projet("TaskManagment", new DateTime(2022, 10, 01), new DateTime(2022, 10, 05), 1000);
            DateTime fin = new DateTime(2022, 10, 05);
            Assert.Equal(fin, projet.getFin());
        }

        [Fact]
        public void TestPrixMO()
        {
            Projet projet = new Projet("TaskManagment", new DateTime(2022, 10, 01), new DateTime(2022, 10, 05), 1000);
            Assert.Equal(1000, projet.getPrixFactureMO());
        }

        [Fact]
        public void TestCoutMissions()
        {
            Mission mission = new Mission("TaskScheduler", "Description de la mission TeskScheduler", 15, new Intervenant("Thierry Peuple", 15.4));
            DateTime date = new DateTime(2022, 09, 13);
            mission.ajoutReleve(date, 10);
            mission.ajoutReleve(date, 5);
            date = new DateTime(2022, 04, 19);
            mission.ajoutReleve(date, 6);

            Projet projet = new Projet("TaskManagment", new DateTime(2022, 10, 01), new DateTime(2022, 10, 05), 1000);

            projet.ajoutMission(mission);

            Assert.Equal(mission, projet.getMissions()[0]);

            Assert.Equal(1000-292.6, projet.margeBruteCourante());
        }
    }
}
