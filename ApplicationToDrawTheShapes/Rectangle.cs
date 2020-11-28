using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace ApplicationToDrawTheShapes
{
    public class Rectangle
    {
        ShapeCoder s= new ShapeCoder();

        Pen Default_Pen = ShapeCoder.Default_Pen;
        Brush Default_Brush = ShapeCoder.Default_Brush;
        int pen_position_defaultX = ShapeCoder.pen_position_defaultX;
        int pen_position_defaultY = ShapeCoder.pen_position_defaultY;
        Graphics GRectangle = ShapeCoder.g;
        string[] error = { "", "" };
        int length, breadth;


        public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
            this.rectangle();

        }

        public void rectangle()
        {

            if (ShapeCoder.fill)
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
