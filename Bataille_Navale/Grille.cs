using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bataille_Navale
{
    public class Grille
    {
       
        private int _width;
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        private int _height;

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }


        public Grille(int width, int height)
        {
            this._height = height;
            this._width = width;

            

        }

        private List<Case> terrain;

        public List<Case> Terrain
        {
            get { return terrain; }
            set { terrain = value; }
        }


        public Case recupCase(int x, int y)
        {
            //Case maCase = new Case();
            //int[] myArray = {x, y};

            //if( ( ( x > 0 ) && ( x <= this._x ) ) && ( ( y > 0 ) && ( y <= this._y ) ) )
            //{
            //    foreach(Case uneCase in this.terrain)
            //    {
            //        if (uneCase.Position == myArray)
            //        {
            //            maCase = uneCase;
            //        }
            //    }
            //}

            //return maCase;
            return null;
        }

    }
}
