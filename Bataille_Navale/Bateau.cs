using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bataille_Navale
{
    class Bateau
    {
        int taille;

        public int Taille
        {
          get { return taille; }
          set { taille = value; }
        }


        String forme;

        public String Forme
        {
          get { return forme; }
          set { forme = value; }
        }


        int[] positions;

        public int[] Positions
        {
            get { return positions; }
            set { positions = value; }
        }


        int sante;

        public int Sante
        {
            get { return sante; }
            set { sante = value; }
        }
     
    

    }
}
