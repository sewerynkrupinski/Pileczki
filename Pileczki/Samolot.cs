using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pileczki
{
    public class Samolot
    {
        public int Ladownosc { get; set; }
        public int Kubatura { get; set; }

        public Samolot(int ladownosc, int kubatura)
        {
            Ladownosc = ladownosc;
            Kubatura = kubatura;
        }

        public int ZaladujSamolot(Pileczka pileczka)
        {
            int Sztuk = 0;  //liczba sztuk załadowanych

            if (pileczka.Masa <=0 || pileczka.Objetosc <=0) //piłeczka musi mieć masę i objętość większą od 0
            {
                throw new ArgumentException();
            }
            
            while (Ladownosc > 0 && Kubatura > 0) //jeżeli osiągniemy limit kubatury lub ładowności zwracamy wynik
            {
                if (pileczka.Masa > Ladownosc || pileczka.Objetosc > Kubatura) //jeżeli masa lub objętość piłeczki jest większa od dostępnej ładowności lub kubatury zwaramy dotychczasową liczbę sztuk
                {
                    return Sztuk;
                }

                Ladownosc -= pileczka.Masa; //jeżeli warunki spełnione pomniejszamy dostępną ładowność i kubaturę o rozmiary piłeczki i dodajemy liczbę sztuk załadowanych
                Kubatura -= pileczka.Objetosc;
                Sztuk++;
            }
            return Sztuk;
        }
    }
}
