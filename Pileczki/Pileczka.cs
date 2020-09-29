using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pileczki
{
    public class Pileczka
    {
        public int Masa { get; set; }
        public int Objetosc { get; set; }

        public Pileczka(int masa, int objetosc)
        {
            Masa = masa;
            Objetosc = objetosc;
        }
    }
}
