using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha04
{
    public class Box
    {
        private double lenght;

        public double Lenght
        {
            get { return lenght; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Lenght cannot be zero or negative");
                }
                lenght = value;
            }
        }
        private double width;

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative");

                }
                width = value;
            }
        }
        private double height;

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative");
                }
                height = value;
            }
        }

        public Box(double lenght, double width, double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }
        public double SurfaceArea()
        {
            return 2 * this.lenght * this.width +
                2 * this.lenght * this.height +
                2 * this.width * this.height;
        }
        public double LateralSurfaceArea()
        {
            return 2 * this.lenght * this.height +
                2 * this.width * this.height;
        }
        public double Volume()
        {
            return this.lenght * this.width * this.height;
        }
    }
}
