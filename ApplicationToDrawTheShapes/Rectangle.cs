using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ApplicationToDrawTheShapes
{
    public class Rectangle
    {
        Pen Default_Pen = Form1.Default_Pen;
        Brush Default_Brush = Form1.Default_Brush;
        int pen_position_defaultX = Form1.pen_position_defaultX;
        int pen_position_defaultY = Form1.pen_position_defaultY;
        Graphics GRectangle = Form1.g;
        bool fill = Form1.fill;
        string[] error = { "", "" };


        public Rectangle(int length, int breadth)
        {

            if (Form1.fill)
            {
                GRectangle.FillRectangle(Default_Brush, pen_position_defaultX, pen_position_defaultY, breadth, length);

            }
            else
            {
                GRectangle.DrawRectangle(Default_Pen, pen_position_defaultX, pen_position_defaultY, breadth, length);
            }
            error[0] = "Rectangle Drawn";

        }

        public string[] error_handling_rectangle()
        {
            return this.error; 
        }
    }
}
