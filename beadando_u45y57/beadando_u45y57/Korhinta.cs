using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando_u45y57
{
    internal class Korhinta : Latvanyossag
    {
        private int maxmenet;
        internal Sor<Csoport> sor = new Sor<Csoport>();

        public Korhinta(int ferohelyek, int maxmenet, int ar)
        {
            uzemel = true;
            this.ferohelyek = ferohelyek;
            this.maxmenet = maxmenet;
            this.Ar = ar;
            bevetel = 0;
        }

        public void Menet()
        {

            if (uzemel == true)
            {
                Beszallas();
                maxmenet--;
                Console.WriteLine("");
                if (maxmenet == 0)
                {
                    uzemel = false;
                }
            }
            else
            {
                Console.WriteLine("A mai napra a Korhinta mar nem uzemel!");
            }
        }

        public void Sorbaallas(Sor<Csoport> sor,bool felulir)
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
       


        public void Sorbaallas(Csoport csoport)
        {
            this.sor.Add(csoport);
        }

        private void Beszallas()
        {
            int menetferohelyek = ferohelyek;
            bool betelt = false;
            int listahossz = sor.Length;
            while (!betelt && listahossz != 0)
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