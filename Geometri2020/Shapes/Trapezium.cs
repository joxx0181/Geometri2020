using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri2020
{
    class Trapezium : Parallelogram
    {
        // parametrized constructor declaration!
        public Trapezium(double angA, double angB, double angC, double angD, double heig) : base(angA, angB, heig)
        {
            // initialization!
            AngleC = angC;
            AngleD = angD;
        }

        // auto implemented properties with get & set accessor  -  Encapsulation!
        public double AngleC { get; set; }
        public double AngleD { get; set; }

        // overriding methods!
        public override double Area()
        {
            return 0.5 * ((AngleA + AngleC) * Height);
        }

        public override double Circumference()
        {
            return AngleA + AngleB + AngleC + AngleD;
        }
    }
}
