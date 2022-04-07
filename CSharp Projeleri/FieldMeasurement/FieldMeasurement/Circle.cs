using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldMeasurement
{
    class Circle : Shape
    {

        private double _radius;

        public double Radius
        {
            get
            { return _radius; }
            set 
            {
                _radius = value;
            }
        }

        public override void CalculateArea()
        {
            Area = Math.PI * Math.Pow(_radius, 2);
        }
        public override void CalculatePerimeter()
        {
          Perimeter = ((Math.PI * 2) * _radius);
        }    }
}
