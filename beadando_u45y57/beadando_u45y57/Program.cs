using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando_u45y57
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Sor<Csoport> sor = new Sor<Csoport>();
            Korhinta korhinta = new Korhinta();

            FileHandler.Instance.InitializeFileHandler(ref korhinta, ref sor);
            FileHandler.Instance.FilebolBeolvasas("korhinta.txt");
            korhinta.Sorbaallas(sor, true); //sorbaallitjuk a nepet
            for (int i = 0; i < korhinta.maxmenet; i++) //menetek szamaszor fut le a korhinta
            {
                korhinta.Menet();
            }

            FileHandler.Instance.FilebaKiiras("game_out.txt");

            Console.ReadKey();
        }
    }
}