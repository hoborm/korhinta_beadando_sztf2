using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace beadando_u45y57
{
    class FileHandler
    {
        //FileStream beolvasas = new FileStream(, FileMode.Open); Ez regen meg mukodott, majd utana kell jarnom, hogy miben valtozott
   string bemenet, kimenet;
        Korhinta korhinta;

        public FileHandler(string bemenet,string kimenet, Korhinta korhinta)
        {
            this.korhinta = korhinta;
            this.bemenet = bemenet;
            this.kimenet = kimenet;
            StreamReader sr = new StreamReader(bemenet);
            FileStream kifile = new FileStream(kimenet,FileMode.Create);
            StreamWriter sw = new StreamWriter(kifile);
        }
        
       


    }
}
