using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando_u45y57
{
    public class Csoport : ICsoportTagokSzama
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

        public void Feloszlik() //fel tudjuk oszlatni a csoportot=0 tagu
        {
            this.emberekszama = 0;
        }

        public void Felvetel(int emberek) //hozza tudunk adni embereket a csoporthoz
        {
            this.emberekszama += emberek;
        }

        public void Elhagyas(int ember) //x db ember el is tudja hagyni a csoportot
        {
            this.emberekszama -= ember;
        }
    }
}