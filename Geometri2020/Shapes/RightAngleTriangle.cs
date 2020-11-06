using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri2020
{
    class RightAngleTriangle : Rectangle
    {
        // parametrized constructor declaration!
        public RightAngleTriangle(double angA, double angB, double hypo) : base(angA, angB)
        {
            // initialization!
            Hypotenuse = hypo;
        }

        // auto implemented property with get & set accessor  -  Encapsulation!
        public double Hypotenuse { get; set; }

        public override double Area()
        {
            return 0.5 * (AngleA * AngleB);
        }

        // overriding methods!
        public override double Circumference()
        {
            return AngleA + AngleB + Hypotenuse;
        }
    }
}
