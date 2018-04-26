using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando_u45y57
{
    public class Korhinta : Latvanyossag
    {
        internal int maxmenet;
        internal Sor<Csoport> sor = new Sor<Csoport>();

        public int Maxmenet
        {
            get { return maxmenet; }
            set { maxmenet = value; }
        }

        public Korhinta(int ferohelyek, int maxmenet, int ar) //ferohelyek, max menet es arat is be tudjuk allitani, bevetel uj korhintanal 0
        {
            uzemel = true;
            this.ferohelyek = ferohelyek;
            this.maxmenet = maxmenet;
            this.Ar = ar;
            bevetel = 0;
        }

        public Korhinta()
        {
            uzemel = true;
            bevetel = 0;
        }

        public void Menet()  //indul a menet!!!!!!
        {
            if (uzemel == true)
            {
                Beszallas();
                maxmenet--;
                Console.WriteLine("");
                if (maxmenet == 0) //itt allitom meg, ha a napi menetek szama mar elerte a maxot, a kovetkezo menetben mar nem tudnak menni az emberek.
                {
                    uzemel = false;
                }
            }
            else
            {
                Console.WriteLine("A mai napra a Korhinta mar nem uzemel!");
            }
        }

        internal void Sorbaallas(Sor<Csoport> sor, bool felulir) //hozzaadja vagy felulirja az adott sort
        {
            if (felulir)
            {
                this.sor = sor;
            }
            else
            {
                foreach (Csoport item in sor)
                {
                    this.sor.Add(item);
                }
            }
        }

        internal void Sorbaallas(Csoport csoport) //hozzaadja az adott csoportot a sorhoz
        {
            this.sor.Add(csoport);
        }

        private void Beszallas() //ezzel pakoljuk fel a latogatokat a korhintara
        {
            int menetferohelyek = ferohelyek;
            bool betelt = false;
            int listahossz = sor.Length;
            while (!betelt&& listahossz != 0) //itt nezem, hogy ne szalljanak fel 2x ugyanazok az emberek egy menetre illetve azt, hogy megtelt-e a menet
            {
                if (menetferohelyek >= sor.Peek().EmberekSzama)
                {
                    listahossz--;
                    bevetel = bevetel + Ar * sor.Peek().EmberekSzama;
                    sor.Pop();
                }
                else
                {
                    betelt = true;
                }
            }
        }
    }
}