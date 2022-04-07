using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldMeasurement
{
    class Square : Shape
    {
        private double _side;

        public double Side
        {
            get { return _side; }
            set { _side = value; }
        }

        public override void CalculateArea()
        {

            Area = Math.Pow(_side, 2);
        }

        public override void CalculatePerimeter()
        {
            Perimeter = _side * 4;
        }
    }
}
