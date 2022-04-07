using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldMeasurement
{
    class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public double SideC
        {
            get { return _sideC; }
            set { _sideC = value; }
        }


        public double SideB
        {
            get { return _sideB; }
            set { _sideB = value; }
        }


        public double SideA
        {
            get { return _sideA; }
            set { _sideA = value; }
        }

        public override void CalculateArea()
        {
            double s = Perimeter / 2;
            double c = s * (s - _sideA) * (s - _sideB) * (s - _sideC);
            Area = (double)Math.Sqrt(c);
        }

        public override void CalculatePerimeter()
        {
            Perimeter = _sideA + _sideB + _sideC;
        }
    }
}
