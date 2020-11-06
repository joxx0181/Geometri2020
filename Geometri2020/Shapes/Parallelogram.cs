using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri2020
{
    class Parallelogram : Rectangle
    {
        // parametrized constructor declaration!
        public Parallelogram(double angA, double angB, double heig) : base(angA, angB)
        {
            // initialization!
            Height = heig;
        }

        // auto implemented property with get & set accessor  -  Encapsulation!
        public double Height { get; set; }

        // overriding methods!
        public override double Area()
        {
            return AngleA * Height;
        }

        public override double Circumference()
        {
            return (2 * AngleA) + (2 * AngleB);
        }
    }
}
