using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            perare();
        }
        public static void perare()
        {
            PerimeterArea perimeterArea = new PerimeterArea();
            perimeterArea.areaCircle();
            perimeterArea.perimeterCircle();
            perimeterArea.areaEllipse();
            perimeterArea.perimeterEllipse();
            perimeterArea.areaParrelelogram();
            perimeterArea.perimeterParrelelogram();
            perimeterArea.areaRectangle();
            perimeterArea.perimeterRectangle();
            perimeterArea.areaRhombus();
            perimeterArea.perimeterRhombus();
            perimeterArea.areaSquare();
            perimeterArea.perimeterSquare();
            perimeterArea.areaTrapeze();
            perimeterArea.perimeterTrapeze();
            perimeterArea.areaTriangle();
            perimeterArea.perimeterTriangle();
        }
    }
}
