using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Square
    {
        private int side;

        public int Side
        {
            //get accessor is executed when the property is read
            get
            {
                return this.side;
            }
            //The set accessor is executed when the property is asigned a new value
            set
            {
                this.side = value;
            }
        }

        //Constructor - This Constructor is a default constructor. It would still be working without being declared.
        public Square()
        {
            //Omkreds(4);
        }

        // Method to calculate the areal.
        public int Arealet(int side)
        {
           int areal = side * side;
            return areal;
        }
        //Method to calculate "omkreds"
        public int Omkreds(int side)
        {
            int kvadrat = side * 4;
            return kvadrat;
        }

    }
}
