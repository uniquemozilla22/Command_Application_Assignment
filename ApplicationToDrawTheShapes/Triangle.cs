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

        Pen Default_Pen = Form1.Default_Pen;
        Brush Default_Brush = Form1.Default_Brush;
        int pen_position_defaultX = Form1.pen_position_defaultX;
        int pen_position_defaultY = Form1.pen_position_defaultY;
        Graphics GTriangle = Form1.g;
        string[] error = { "", "" };
        public Triangle(int side1,int side2,int side3)
        {


            Point p1 = new Point(pen_position_defaultX, pen_position_defaultY);
            Point p2 = new Point(side1, pen_position_defaultY);
            Point p3 = new Point(side2, side3);

            Point[] points = { p1, p2, p3 };

            if (Form1.fill)
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
