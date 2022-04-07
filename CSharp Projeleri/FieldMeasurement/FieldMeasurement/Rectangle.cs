using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldMeasurement
{
    class Rectangle : Shape
    {
        private double _width;
        private double _height;

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }


        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public override void CalculateArea()
        {
            Area = _width * _height;
        }
        public override void CalculatePerimeter()
        {
            Perimeter = (_width + _height) * 2;
        }    }
}
