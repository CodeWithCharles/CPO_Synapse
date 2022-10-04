using CPO_Synapse.Classes;
using System;
using Xunit;

namespace CPO_Synapse_Tests
{
    public class IntervenantTest
    {
        [Fact]
        public void TestCreation()
        {
            Intervenant intervenant = new Intervenant("Joe Denver", 10.4);
            Assert.NotNull(intervenant);
        }

        [Fact]
        public void TestNom()
        {
            Intervenant intervenant = new Intervenant("Nicolas Lecordier", 0);
            Assert.Equal("Nicolas Lecordier", intervenant.getNom());
        }

        [Fact]
        public void TestTauxHoraire()
        {
            Intervenant intervenant = new Intervenant("Pascal Mercy", 23.7);
            Assert.Equal(23.7, intervenant.getTauxHoraire());
        }
    }
}
