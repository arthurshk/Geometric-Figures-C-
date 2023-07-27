using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_Figures
{
    class PerimeterArea : circle_I, EllipseI,TrapezeI, ParrelelogramI, RectangleI, RhombusI, SquareI, TriangleI
    {
        private double areaCirclez;
        private double perimeterCirclez;
        private double areaEllipsez;
        private double perimeterEllipsez;
        private double areaSquarez;
        private double perimeterSquarez;
        private double areaRectanglez;
        private double perimeterRectanglez;
        private double areaTrianglez;
        private double perimeterTrianglez;
        private double areaTrapezez;
        private double perimeterTrapezez;
        private double perimeterParelelogramz;
        private double areaParelelogramz;
        private double areaRhombusz;
        private double perimeterRhombusz;

        public static int length { get; set; }
        public static int length2 { get; set; }
        public static int width { get; set; }
        public static int side { get; set; }
        public static int radius { get; set; }
        public static int height { get; set; }
        public static int side2 { get; set; }
        
        public void perimeterCircle()
        {
            Console.WriteLine("Enter radius of circle");
            radius = Convert.ToInt32(Console.ReadLine());
            perimeterCirclez = 3.14 * 2 * radius;
            Console.WriteLine($"Perimeter of circle is {perimeterCirclez}");
        }
        public void areaCircle()
        {
            Console.WriteLine("Enter radius of circle");
            radius = Convert.ToInt32(Console.ReadLine());
            areaCirclez = 3.14 * Math.Pow(radius, 2);
            Console.WriteLine($"Area of circle is {areaCirclez}");
        }
        public void areaEllipse()
        {
            Console.WriteLine("Enter length of ellipse");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width of ellipse");
            width = Convert.ToInt32(Console.ReadLine());
            areaEllipsez = length * width * 3.14;
            Console.WriteLine($"area of ellipse is {areaEllipsez}");
        }
        public void perimeterEllipse()
        {
            Console.WriteLine("Enter length of ellipse");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width of ellipse");
            width = Convert.ToInt32(Console.ReadLine());
            perimeterEllipsez = length * width;
            Console.WriteLine($"perimeter of ellipse is {perimeterEllipsez}");
        }
        public void areaSquare()
        {
            Console.WriteLine("Enter side of square");
            side = Convert.ToInt32(Console.ReadLine());
            areaSquarez = side * side;
            Console.WriteLine($"Area of square is {areaSquarez}");
        }
        public void perimeterSquare()
        {
            Console.WriteLine("Enter side of square");
            side = Convert.ToInt32(Console.ReadLine());
            perimeterSquarez = side * 4;
            Console.WriteLine($"perimeter of square is {perimeterSquarez}");
        }
        public void areaRectangle()
        {
            Console.WriteLine("Enter length of rectangle");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width of rectangle");
            width = Convert.ToInt32(Console.ReadLine());
            areaRectanglez = length * width;
            Console.WriteLine($"area of rectangle is {areaRectanglez}");
        }
        public void perimeterRectangle()
        {
            Console.WriteLine("Enter length of rectangle");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width of rectangle");
            width = Convert.ToInt32(Console.ReadLine());
            perimeterRectanglez = (2 * length) + (2 * width);
            Console.WriteLine($"perimeter of rectangle is {perimeterRectanglez}");
        }
        public void areaTriangle()
        {
            Console.WriteLine("Enter length of triangle");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height of triangle");
            height = Convert.ToInt32(Console.ReadLine());
            areaTrianglez = length * height / 2;
            Console.WriteLine($"area of Triangle is {areaTrianglez}");
        }
        public void perimeterTriangle()
        {
            Console.WriteLine("Enter length of triangle");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side of triangle");
            side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side 2 ");
            side2 = Convert.ToInt32(Console.ReadLine());
            perimeterTrianglez = side + length + side2;
            Console.WriteLine($"perimeter of Triangle is {perimeterTrianglez}");
        }
        public void areaTrapeze()
        {
            Console.WriteLine("Enter length of trapeze");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter length 2 of trapeze");
            length2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height of trapeze");
            height = Convert.ToInt32(Console.ReadLine());
            areaTrapezez = length + length2 / 2 * height;
            Console.WriteLine($"area of trapeze is {areaTrapezez}");
        }
        public void perimeterTrapeze()
        {
            Console.WriteLine("Enter length of trapeze");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter length 2 of trapeze");
            length2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side of trapeze");
            side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side 2 of trapeze");
            side2 = Convert.ToInt32(Console.ReadLine());
            perimeterTrapezez = length + length2 + side + side2;
            Console.WriteLine($"perimeter of trapeze is {perimeterTrapezez}");
        }
        public void areaParrelelogram()
        {
            Console.WriteLine("Enter length of parrelelogram");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height of parrelelogram");
            height = Convert.ToInt32(Console.ReadLine());
            areaParelelogramz = length * height;
            Console.WriteLine($"area of Parrelelogram is {areaParelelogramz}");
        }
        public void perimeterParrelelogram()
        {
            Console.WriteLine("Enter length of parrelelogram");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side of parrelelogram");
            side = Convert.ToInt32(Console.ReadLine());
            perimeterParelelogramz = (length + side) * 2;
            Console.WriteLine($"perimeter of Parrelelogram is {perimeterParelelogramz}");
        }
        public void areaRhombus()
        {
            Console.WriteLine("Enter length of rhombus");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter length 2 of rhombus");
            length2 = Convert.ToInt32(Console.ReadLine());
            areaRhombusz = length*length2 / 2;
            Console.WriteLine($"area of Rhombus is {areaRhombusz}");
        }
        public void perimeterRhombus()
        {
            Console.WriteLine("Enter side rhombus");
            side = Convert.ToInt32(Console.ReadLine());
            perimeterRhombusz = side * 4;
            Console.WriteLine($"perimeter of Rhombus is {perimeterRhombusz}");
        }
    }
}
