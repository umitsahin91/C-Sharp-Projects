using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldMeasurement
{
    public abstract class Shape
    {
        private double _area;
        private double _perimeter;

        public double Area
        {
            get
            {
                return _area;
            }
            set
            {
                _area = value;
            }
        }
        public double Perimeter
        {
            get
            {
                return _perimeter;
            }
            set 
            {
                _perimeter = value;
            }
        }

        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();
    }
}
