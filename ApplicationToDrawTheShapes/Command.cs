using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ApplicationToDrawTheShapes
{
    public class Command
    {
        string[] error = { "", "" };
        

        public void MoveTo(int point1, int point2)
        {
            ShapeCoder.pen_position_defaultX = point1;
            ShapeCoder.pen_position_defaultY = point2;
            error[0] = "Initial position moved to (" + point1 + " , " + point2 + ")";
        }
        public void DrawTo(int point1, int point2)
        {
            ShapeCoder.pen_position_defaultX = point1;
            ShapeCoder.pen_position_defaultY = point2;
            error[0] = "Initial position moved to (" + point1 + " , " + point2 + ")";
        }


        public void PenColorSwitcher(String color)
        {
            error[0] = "**Pen color set : " + color + "**";

            if (!ShapeCoder.fill)
            {
                switch (color)
                {
                    case "green":
                        {

                            ShapeCoder.Default_Pen = new Pen(Color.Green);
                            break;
                        }

                    case "blue":
                        {
                            ShapeCoder.Default_Pen = new Pen(Color.Blue);
                            break;
                        }
                    case "brown":
                        {
                            ShapeCoder.Default_Pen = new Pen(Color.Brown);
                            break;
                        }

                    case "yellow":
                        {
                            ShapeCoder.Default_Pen = new Pen(Color.Yellow);
                            break;
                        }

                    case "white":
                        {
                            ShapeCoder.Default_Pen = new Pen(Color.White);
                            break;
                        }
                    case "red":
                        {
                            ShapeCoder.Default_Pen = new Pen(Color.Red);
                            break;
                        }
                    default:
                        {
                            error[0] = "**Pen color not found : " + color + "**";

                            break;
                        }
                }

            }
            else
            {
                switch (color)
                {
                    case "green":
                        {
                            ShapeCoder.Default_Brush = new SolidBrush(Color.Green);
                            break;
                        }

                    case "blue":
                        {
                            ShapeCoder.Default_Brush = new SolidBrush(Color.Blue);
                            break;
                        }
                    case "brown":
                        {
                            ShapeCoder.Default_Brush = new SolidBrush(Color.Brown);
                            break;
                        }

                    case "yellow":
                        {
                            ShapeCoder.Default_Brush = new SolidBrush(Color.Yellow);
                            break;
                        }

                    case "white":
                        {
                            ShapeCoder.Default_Brush = new SolidBrush(Color.White);
                            break;
                        }
                    case "red":
                        {
                            ShapeCoder.Default_Brush = new SolidBrush(Color.Red);
                            break;
                        }
                    default:
                        {
                            error[0] = "**Filling color not found : " + color + "**";
                            break;
                        }
                }

            }

        }


        public string[] error_handling_command()
        {
            return this.error;
        }
    }
}
