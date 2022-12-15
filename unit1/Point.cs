using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit1
{
    public class Point
    {
        protected int pointValue;
        protected int pointX;
        protected int pointY;
        public Point(int coordx, int coordY, int value)
        {
            CoordX = coordx;
            CoordY = coordY;
            Value = value;
        }
        public int CoordX
        {
            get
            {
                return this.pointX;
            }
            set
            {
                this.pointX = value;
            }
        }
        public int CoordY
        {
            get
            {
                return this.pointY;
            }
            set
            {
                this.pointY = value;
            }
        }
        public int Value
        {
            get
            {
                return this.pointValue;
            }
            set
            {
                this.pointValue = value;
            }
        }

        public double HashPoint
        {
            get
            {
                var hash = (this.CoordX + this.CoordY * 100 + (double)(this.Value / 151.0));
                return hash;
            }
        }

    }
}
