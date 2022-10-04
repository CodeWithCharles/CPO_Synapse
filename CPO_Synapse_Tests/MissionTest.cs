using CPO_Synapse.Classes;
using System;
using Xunit;

namespace CPO_Synapse_Tests
{
    public class MissionTest
    {
        [Fact]
        public void TestCreation()
        {
            Mission mission = new Mission("Test", "Description de test", 0, null);
            Assert.NotNull(mission);
        }

        [Fact]
        public void TestNom()
        {
            Mission mission = new Mission("TaskScheduler", null, 0, null);
            Assert.Equal("TaskScheduler", mission.getNom());
        }

        [Fact]
        public void TestDescription()
        {
            Mission mission = new Mission("TaskScheduler", "Description de la mission TaskScheduler", 0, null);
            Assert.Equal("Description de la mission TaskScheduler", mission.getDescription());
        }

        [Fact]
        public void TestNbHeuresPrevues()
        {
            Mission mission = new Mission("TaskScheduler", "Description de la mission TaskScheduler", 15, null);
            Assert.Equal(15, mission.getNbHeuresPrevues());
        }

        [Fact]
        public void TestIntervenant()
        {
            Mission mission = new Mission("TaskScheduler", "Description de la mission TeskScheduler", 15, new Intervenant("Thierry Peuple", 15.4));
            Assert.Equal("Thierry Peuple", mission.getIntervenant().getNom());
            Assert.Equal(15.4, mission.getIntervenant().getTauxHoraire());
        }

        [Fact]
        public void TestAjoutReleve()
        {
            Mission mission = new Mission("TaskScheduler", "Description de la mission TeskScheduler", 15, new Intervenant("Thierry Peuple", 15.4));
            DateTime date = new DateTime(2022, 09, 13);
            mission.ajoutReleve(date, 10);
            Assert.Equal(8, mission.getReleveDate(date));

            mission.ajoutReleve(date, 5);
            Assert.Equal(13, mission.getReleveDate(date));

            date = new DateTime(2022, 04, 19);
            mission.ajoutReleve(date, 6);
            Assert.Equal(6, mission.getReleveDate(date));
            Assert.Equal(19, mission.getNbHeuresEffectuees());
        }
    }
}
