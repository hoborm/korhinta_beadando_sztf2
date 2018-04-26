using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando_u45y57
{
    class Program
    {
        static void Main(string[] args)
        {

            Sor<Csoport> sor = new Sor<Csoport>();
            sor.Add(new Csoport(2));
            sor.Add(new Csoport(3));
            sor.Add(new Csoport(1));
            sor.Add(new Csoport(4));
            sor.Add(new Csoport(1));
            sor.Add(new Csoport(5));
            sor.Add(new Csoport(2));
            

            Korhinta korhinta = new Korhinta(10,5,1);

            korhinta.Sorbaallas(sor,true);

            for (int i = 0; i < 9; i++)
            {
                korhinta.Menet();
            }

            Console.ReadKey();

        }
    }
}
