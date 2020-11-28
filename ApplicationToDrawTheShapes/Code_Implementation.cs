
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationToDrawTheShapes
{
    public class Code_Implementation
    {
        string[] error = { "", "" };
        string[] code ;
        Command comm = new Command();

        public Code_Implementation(string[] code)
        {
            this.code = code;
            this.SwitichingFunctions(code);
        }


        public void SwitichingFunctions(string[] code)
        {
            string firstword = code[0].Trim();
            string[] parameters = code[1].Split(',');

            for (int i=0; i < parameters.Length; i++)
            {
                parameters[i] = parameters[i].Trim();
            }

            if (firstword == "moveto")
            {
                try
                {
                    if(parameters.Length==2)
                    {
                        int code1 = int.Parse(parameters[0]);
                        int code2 = int.Parse(parameters[1]);
                        comm.MoveTo(code1, code2);
                        error = comm.error_handling_command();
                    }
                    else
                    {
                        error[0] = "**Please pass a corrcet Syntax for moveTo**";
                    }
                }
                catch (Exception e)
                {
                    error[0] = "Please enter a valid number.";
                }
            }
            else if (firstword == "drawto")
            {

                try
                {
                    if(parameters.Length==2)
                    {

                        int code1 = int.Parse(parameters[0]);
                        int code2 = int.Parse(parameters[1]);
                        comm.DrawTo(code1, code2);
                        error = comm.error_handling_command();
                    }
                    else
                    {
                        error[0] = "**Please pass a corrcet Syntax for drawTo**";

                    }

                }
                catch (Exception e)
                {
                    error[0] = "Please enter a valid number.";
                }
            }
            else if (firstword == "rectangle")
            {
                if (parameters.Length == 2)
                {
                    try
                    {
                        int code1 = int.Parse(parameters[0]);
                        int code2 = int.Parse(parameters[1]);
                        Rectangle r = new Rectangle(code2, code1);
                        error = r.error_handling_rectangle();
                    }
                    catch (Exception e)
                    {
                        error[0] = "Please enter a valid number.";
                    }
                }
                else
                {
                    error[0] = "**Please pass a corrcet Syntax for Rectangle**";

                }

            }
            else if (firstword == "circle")
            {
                if (parameters.Length == 1)
                {
                    try
                    {
                        int code1 = int.Parse(parameters[0]);
                        Circle r = new Circle(code1);
                        error = r.error_handling_circle();

                    }
                    catch (Exception e)
                    {
                        error[0] = "Please enter a valid number.";
                    }
                }
                else
                {
                    error[0] = "**Please pass a corrcet Syntax for Circle**";

                }

            }
            else if (firstword == "triangle")
            {
                if (parameters.Length == 3)
                {
                    try
                    {
                        int code1 = int.Parse(parameters[0]);
                        int code2 = int.Parse(parameters[1]);
                        int code3 = int.Parse(parameters[2]);

                        Triangle r = new Triangle(code1, code2, code3);
                        error = r.error_handling_Triangle();

                    }
                    catch (Exception e)
                    {
                        error[0] = "Please enter a valid number.";
                    }
                }
                else
                {
                    error[0] = "**Please pass a corrcet Syntax for Triangle**";

                }
            }
            else if (firstword == "pen")
            {
                if (parameters.Length == 1)
                {
                    comm.PenColorSwitcher(parameters[0]);
                    error = comm.error_handling_command();
                }
                else
                {
                    error[0] = "**Use pen < color_name > properly**";
                }

            }
            else if (firstword == "fill")
            {
                if (parameters[0] == "on")
                {
                    ShapeCoder.fill = true;
                    error[0] = "Fill turned on";

                }
                else if (parameters[0] == "off")
                {
                    ShapeCoder.fill = false;
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