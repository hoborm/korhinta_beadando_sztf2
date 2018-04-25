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
        private Sor<Csoport> sor = new Sor<Csoport>();

        public Korhinta(int ferohelyek, int maxmenet, int ar)
        {
            uzemel = true;
            this.ferohelyek = ferohelyek;
            this.maxmenet = maxmenet;
            this.ar = ar;
        }

        public void Menet()
        {
            if (uzemel == true)
            {
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
    }
}