using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri2020
{
    class Rectangle : Square
    {
        // parametrized constructor declaration!
        public Rectangle(double angA, double angB) : base(angA)
        {
            // initialization!
            AngleB = angB;
        }

        // auto implemented property with get & set accessor  -  Encapsulation!
        public double AngleB { get; set; }

        // overriding methods!
        public override double Area()
        {
            return AngleA * AngleB;
        }

        public override double Circumference()
        {
            return (AngleA + AngleB) * 2;
        }
    }
}
