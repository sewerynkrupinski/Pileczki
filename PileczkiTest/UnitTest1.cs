using NUnit.Framework;
using Pileczki;
using System;

namespace PileczkiTest
{
    public class Tests
    {
        [TestCase(1000,500,1,20, 25)]
        [TestCase(1000, 2000, 1, 20, 100)]
        [TestCase(50, 2000, 1, 20, 50)]
        [TestCase(1, 100, 1, 20, 1)]
        [TestCase(0, 2000, 1, 20, 0)]
        [TestCase(2000, 0, 1, 20, 0)]
        [TestCase(2000, 2000, 10, 2500, 0)]
        [TestCase(100, 2000, 100, 10, 1)]
        [TestCase(2000, 100, 10, 100, 1)]
        [TestCase(1, 1, 10, 100, 0)]
        [TestCase(7, 7, 3, 2, 2)]
        [TestCase(-50, 7, 3, 2, 0)]
        [TestCase(40, -20, 3, 2, 0)]

        public void PileczkaMaMaseIObjetosc(int ladownoscSamolotu, int kubaturaSamolotu, int masaPileczki, int objetoscPileczki, int sztuki)
        {
            Samolot s = new Samolot(ladownoscSamolotu, kubaturaSamolotu);
            Pileczka p = new Pileczka(masaPileczki, objetoscPileczki);

            var zaladowanoSztuk = s.ZaladujSamolot(p);
            Assert.AreEqual(sztuki, zaladowanoSztuk);
        }

        [TestCase(2000, 2000, 0, 20)]
        [TestCase(1000, 500, 1, 0)]
        [TestCase(1000, 500, -1, 5)]
        [TestCase(1000, 500, 5, -1)]
        public void PileczkaNieMaMasyLubObjetosci(int ladownoscSamolotu, int kubaturaSamolotu, int masaPileczki, int objetoscPileczki)
        {
            Samolot s = new Samolot(ladownoscSamolotu, kubaturaSamolotu);
            Pileczka p = new Pileczka(masaPileczki, objetoscPileczki);

            Assert.Throws<ArgumentException>(() => s.ZaladujSamolot(p));
        }
    }
}