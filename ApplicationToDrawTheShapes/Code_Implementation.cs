using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationToDrawTheShapes
{
    public class Code_Implementation
    {
        string[] error = { "", "" }
        string[] code ;
        public Code_Implementation(string[] code)
        {
            this.code = code;
            SwitichingFunctions(code);
        }


        public void SwitichingFunctions(string[] code)
        {
            if (code[0] == "moveto")
            {
                try
                {
                    int code1 = int.Parse(code[1]);
                    int code2 = int.Parse(code[2]);
                    MoveTo(code1, code2);
                }
                catch (Exception e)
                {
                    error[0] = "Please enter a valid number.";
                }
            }
            else if (code[0] == "drawto")
            {

                try
                {
                    int code1 = int.Parse(code[1]);
                    int code2 = int.Parse(code[2]);
                    DrawTo(code1, code2);
                }
                catch (Exception e)
                {
                    error[0] = "Please enter a valid number.";
                }
            }
            else if (code[0] == "rectangle")
            {
                if (code.Length == 3)
                {
                    try
                    {
                        int code1 = int.Parse(code[1]);
                        int code2 = int.Parse(code[2]);
                        DrawRectangle(code1, code2);
                    }
                    catch (Exception e)
                    {
                        error[0] = "Please enter a valid number.";
                    }
                }
                else
                {
                    error[0] = "**Pass only 2 parameters**";
                }

            }
            else if (code[0] == "circle")
            {
                if (code.Length == 2)
                {
                    try
                    {
                        int rad = int.Parse(code[1]);
                        DrawCircle(rad);
                    }
                    catch (Exception e)
                    {
                        error[0] = "Please enter a valid number.";
                    }
                }
                else
                {
                    error[0] = "**Pass only a radius value**";
                }

            }
            else if (code[0] == "triangle")
            {
                if (code.Length == 4)
                {
                    try
                    {
                        int side1 = int.Parse(code[1]);
                        int side2 = int.Parse(code[2]);
                        int side3 = int.Parse(code[3]);
                        DrawTriangle(side1, side2, side3);
                    }
                    catch (Exception e)
                    {
                        error[0] = "Please enter a valid number.";
                    }
                }
                else
                {
                    error[0] = "**Pass the length for each side**";
                }
            }
            else if (code[0] == "pen")
            {
                if (code.Length == 2)
                {
                    PenColorSwitcher(code[1]);
                }
                else
                {
                    error[0] = "**Use pen < color_name > properly**";
                }

            }
            else if (code[0] == "fill")
            {
                if (code[1] == "on")
                {
                    this.fill = true;
                    error[0] = "Fill turned on";

                }
                else if (code[1] == "off")
                {
                    this.fill = false;
                    error[0] = "Fill turned off";

                }
                else
                {
                    error[0] = "Not a valid command";
                }
            }
            else
            {
                error[0] = "**Program dont have a " + code[0] + " method**";
            }

        }

        public string[] Error_Handling_CodeImplementation()
        {
            return this.error;
        }

    }
}
