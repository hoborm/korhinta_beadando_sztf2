using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando_u45y57
{
    internal class Csoport : ICsoportTagokSzama
    {
        private int emberekszama;

        public int EmberekSzama
        {
            get
            {
                return emberekszama;
            }
        }

        public Csoport(int emberekszama)
        {
            this.emberekszama = emberekszama;
        }

        public Csoport()
        {
            emberekszama = 0;
        }

        public void Feloszlik()
        {
            this.emberekszama = 0;
        }

        //Meg fejleszthetjuk a csoportot, hogy emberek elhagyhassak illetve belephessenek a csoportba.
    }
}