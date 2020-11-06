using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri2020
{
    // abstraction!
    public abstract class Shape
    {
        // abstract method declaration - declares an access modifier, return type and method signature!
        public abstract double Circumference();
        public abstract double Area();
    }
}
