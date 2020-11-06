using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri2020
{
    class Square : Shape
    {
        // parametrized constructor declaration!
        public Square(double angA)
        {
            // initialization!
            AngleA = angA;
        }

        // auto implemented property with get & set accessor  -  Encapsulation!
        public double AngleA { get; set; }

        // overriding methods!
        public override double Area()
        {
            return AngleA * AngleA;
        }

        public override double Circumference()
        {
            return AngleA * 4;
        }
    }
}
