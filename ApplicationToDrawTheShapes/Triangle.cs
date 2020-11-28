using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ApplicationToDrawTheShapes
{
    class Triangle
    {

        Pen Default_Pen = ShapeCoder.Default_Pen;
        Brush Default_Brush = ShapeCoder.Default_Brush;
        int pen_position_defaultX = ShapeCoder.pen_position_defaultX;
        int pen_position_defaultY = ShapeCoder.pen_position_defaultY;
        Graphics GTriangle = ShapeCoder.g;
        string[] error = { "", "" };
        public Triangle(int side1,int side2,int side3)
        {


            Point p1 = new Point(pen_position_defaultX, pen_position_defaultY);
            Point p2 = new Point(side1, pen_position_defaultY);
            Point p3 = new Point(side2, side3);

            Point[] points = { p1, p2, p3 };

            if (ShapeCoder.fill)
            {
                GTriangle.FillPolygon(Default_Brush, points);
            }
            else
            {
                GTriangle.DrawPolygon(Default_Pen, points);

            }
            error[0] = "Triangle Drawn";
        }

        public string[] error_handling_Triangle()
        {
            return this.error;
        }

    }
}
