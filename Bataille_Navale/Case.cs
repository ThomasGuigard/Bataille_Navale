using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bataille_Navale
{
    public class Case
    {
        bool fired;

        public bool Fired
        {
            get { return fired; }
            set { fired = value; }
        }
        Bateau bateau;

        internal Bateau Bateau
        {
            get { return bateau; }
            set { bateau = value; }
        }
        int[] position;

        public int[] Position
        {
            get { return position; }
            set { position = value; }
        }


 
    }
}
