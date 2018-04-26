using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace beadando_u45y57
{
    public sealed class FileHandler
    {
        private static FileHandler instance = new FileHandler();
        private Korhinta korhinta;
        private StreamWriter sw;
        private FileStream kifile;
        private StreamReader sr;
        public string bemenet;
        private int csoportok;
        private Sor<Csoport> sor;

        public FileHandler()
        {
        }

        public static FileHandler Instance
        {
            get
            {
                return instance;
            }
        }

        public void InitializeFileHandler(ref Korhinta korhinta, ref Sor<Csoport> sor)
        {
            instance.korhinta = korhinta;
            this.sor = sor;
        }

        public void FilebaKiiras(string path)
        {
            kifile = new FileStream(path, FileMode.Create);
            sw = new StreamWriter(kifile);

            sw.WriteLine(korhinta.bevetel);
            sw.Close();
            kifile.Close();
        }

        public void FilebolBeolvasas(string bemenet)
        {
            sr = new StreamReader(bemenet);
            string elsosor;
            string[] adatok = new string[3];
            elsosor = sr.ReadLine();
            adatok = elsosor.Split(' ');

            csoportok = Convert.ToInt32(adatok[2]);

            while (!sr.EndOfStream)
            {
                sor.Add(new Csoport(Convert.ToInt32(sr.ReadLine())));
            }

            korhinta.Ferohelyek = Convert.ToInt32(adatok[0]);
            korhinta.Maxmenet = Convert.ToInt32(adatok[1]);
            korhinta.Ar = 1;
            sr.Close();
        }

        #region regi

        //FileStream beolvasas = new FileStream(, FileMode.Open); Ez regen meg mukodott, majd utana kell jarnom, hogy miben valtozott
        //public string bemenet, kimenet;

        //private Korhinta korhinta;

        //public FileHandler(string bemenet, string kimenet, Korhinta korhinta)
        //{
        //    this.korhinta = korhinta;
        //    this.bemenet = bemenet;
        //    this.kimenet = kimenet;
        //    StreamReader sr = new StreamReader(bemenet);
        //    FileStream kifile = new FileStream(kimenet, FileMode.Create);
        //    StreamWriter sw = new StreamWriter(kifile);
        //}

        #endregion regi
    }
}