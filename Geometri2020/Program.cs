using System;

namespace Geometri2020
{
    class Program
    {
        static void Main(string[] args)
        {
            // multiple objects  -  polymorphism!
            Shape squa = new Square(10);
            Shape rect = new Rectangle(6, 4);
            Shape trap = new Trapezium(8, 12, 6, 3, 10);
            Shape para = new Parallelogram(4, 10, 8);
            Shape tria = new RightAngleTriangle(12, 5, 7);

            double resA = 0;
            double resC = 0;

            Console.WriteLine("Select a shape: \n1) Square\n2) Rectangle\n3) Trapezium\n4) Parallelogram\n5) Right-Angle-Triangle");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    resA = squa.Area();
                    resC = squa.Circumference();
                    break;
                case "2":
                    resA = rect.Area();
                    resC = rect.Circumference();
                    break;
                case "3":
                    resA = trap.Area();
                    resC = trap.Circumference();
                    break;
                case "4":
                    resA = para.Area();
                    resC = para.Circumference();
                    break;
                case "5":
                    resA = tria.Area();
                    resC = tria.Circumference();
                    break;
                default:
                    Console.WriteLine("you have not entered correctly");
                    break;
            }
            Console.WriteLine("The area of the shape is: " + resA);
            Console.WriteLine("The circumference of the shape is: " + resC);

            Console.ReadKey();
        }
    }
}
