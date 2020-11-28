using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ApplicationToDrawTheShapes
{
    public class Circle
    {
        Pen Default_Pen = ShapeCoder.Default_Pen;
        Brush Default_Brush = ShapeCoder.Default_Brush;
        int pen_position_defaultX = ShapeCoder.pen_position_defaultX;
        int pen_position_defaultY = ShapeCoder.pen_position_defaultY;
        Graphics GCircle = ShapeCoder.g;
        string[] error = { "", "" };
        public Circle(int radius)
        {

            if (ShapeCoder.fill)
            {
                GCircle.FillEllipse(Default_Brush, pen_position_defaultX, pen_position_defaultY, radius, radius);

            }
            else
            {
                GCircle.DrawEllipse(Default_Pen, pen_position_defaultX, pen_position_defaultY, radius, radius);

            }
            error[0] = "Circle Drawn";
        }

        public string[] error_handling_circle()
        {
            return this.error;
        }

    }
}
