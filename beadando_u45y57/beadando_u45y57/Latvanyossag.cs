using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando_u45y57
{
    public abstract class Latvanyossag
    {
        internal int ferohelyek;
        internal bool uzemel;
        internal static int ar;
        internal int bevetel;

        public int Ar { get { return ar; } set { ar = value; } }
        public int Ferohelyek { get { return ferohelyek; } set { ferohelyek = value; } }
    }
}