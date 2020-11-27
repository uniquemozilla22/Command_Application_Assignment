using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationToDrawTheShapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }

        Validation valid;

        int pen_position_defaultX = 10;
        int pen_position_defaultY = 10;
        bool fill = false;
        Pen Default_Pen = new Pen(Color.White);
        SolidBrush Default_Brush = new SolidBrush(Color.White);

        
        public void Command_Implementation(String code , String command)
        {

            //converting the code to the lower case to be case insensative
            code = code.ToLower();
            command = command.ToLower();
            String[] code_arr =  code.Split(' ');

            if (command == "run")
            {
                SwitichingFunctions(code_arr);
            }
            else if (command == "clear")
            {
            }
            else if (command == "reset")
            {
            }

        }

        public void SwitichingFunctions(String[] code)
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
                    this.label17.Text = "Please enter a valid number.";
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
                    this.label17.Text = "Please enter a valid number.";
                }
            }
            else if (code[0] == "rectangle")
            {
                if(code.Length==3)
                {
                    try
                    {
                        int code1 = int.Parse(code[1]);
                        int code2 = int.Parse(code[2]);
                        DrawRectangle(code1, code2);
                    }
                    catch (Exception e)
                    {
                        this.label17.Text = "Please enter a valid number.";
                    }
                }
                else
                {
                    this.label17.Text = "**Pass only 2 parameters**";
                }
                
            }
            else if (code[0] == "circle")
            {
                if(code.Length==2)
                {
                    try
                    {
                        int rad = int.Parse(code[1]);
                        DrawCircle(rad);
                    }
                    catch (Exception e)
                    {
                        this.label17.Text = "Please enter a valid number.";
                    }
                }
                else
                {
                    this.label17.Text = "**Pass only a radius value**";
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
                        DrawTriangle(side1,side2,side3);
                    }
                    catch (Exception e)
                    {
                        this.label17.Text = "Please enter a valid number.";
                    }
                }
                else
                {
                    this.label17.Text = "**Pass the length for each side**";
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
                    this.label17.Text = "**Use pen < color_name > properly**";
                }

            }
            else if (code[0] == "fill")
            {
                if(code[1]=="on")
                {
                    this.fill = true;
                    this.label17.Text = "Fill turned on";

                }
                else if(code[1]=="off")
                {
                    this.fill = false;
                    this.label17.Text = "Fill turned off";

                }
                else
                {
                    this.label17.Text = "Not a valid command";
                }
            }
            else
            {
                this.label17.Text = "**Program dont have a " + code[0] + " method**";
            }
        
        }

        public void PenColorSwitcher(String color)
        {
            this.label17.Text = "**Pen color set : " + color + "**";

            if(!fill)
            {
                switch (color)
                {
                    case "green":
                        {
                            Default_Pen = new Pen(Color.Green);
                            break;
                        }

                    case "blue":
                        {
                            Default_Pen = new Pen(Color.Blue);
                            break;
                        }
                    case "brown":
                        {
                            Default_Pen = new Pen(Color.Brown);
                            break;
                        }

                    case "yellow":
                        {
                            Default_Pen = new Pen(Color.Yellow);
                            break;
                        }

                    case "white":
                        {
                            Default_Pen = new Pen(Color.White);
                            break;
                        }
                    case "red":
                        {
                            Default_Pen = new Pen(Color.Red);
                            break;
                        }
                    default:
                        {
                            this.label17.Text = "**Pen color not found : " + color + "**";

                            MessageBox.Show("Sorry ! The color " + color + " is not Implemented on the program", "Color Not Found!");
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
                            Default_Brush = new SolidBrush(Color.Green);
                            break;
                        }

                    case "blue":
                        {
                            Default_Brush = new SolidBrush(Color.Blue);
                            break;
                        }
                    case "brown":
                        {
                            Default_Brush = new SolidBrush(Color.Brown);
                            break;
                        }

                    case "yellow":
                        {
                            Default_Brush = new SolidBrush(Color.Yellow);
                            break;
                        }

                    case "white":
                        {
                            Default_Brush = new SolidBrush(Color.White);
                            break;
                        }
                    case "red":
                        {
                            Default_Brush = new SolidBrush(Color.Red);
                            break;
                        }
                    default:
                        {
                            this.label17.Text = "**Filling color not found : " + color + "**";

                            MessageBox.Show("Sorry ! The color " + color + " is not Implemented on the program", "Color Not Found!");
                            break;
                        }
                }

            }

        }

        public void MoveTo(int point1, int point2)
        {
            this.pen_position_defaultX = point1;
            this.pen_position_defaultY = point2;   
            this.label17.Text="Initial position moved to ("+point1+ " , " + point2+")";
            
        }

        public void DrawTo(int point1, int point2)
        {

        }

        public void DrawRectangle(int length, int breadth)
        {

            Graphics Rect = this.pictureBox1.CreateGraphics();
            if(fill)
            {
                Rect.FillRectangle(Default_Brush, pen_position_defaultX, pen_position_defaultY, breadth, length);

            }
            else
            {
                Rect.DrawRectangle(Default_Pen, pen_position_defaultX, pen_position_defaultY, breadth, length);
            }
            this.label17.Text = "Rectangle Drawn";

        }

        public void DrawCircle(int radius)
        {
            Graphics Circle = this.pictureBox1.CreateGraphics();
            if (fill)
            {
                Circle.FillEllipse(Default_Brush, pen_position_defaultX, pen_position_defaultY, radius * 2, radius * 2);

            }
            else
            {
                Circle.DrawEllipse(Default_Pen, pen_position_defaultX, pen_position_defaultY, radius * 2, radius * 2);

            }
            this.label17.Text = "Circle Drawn";

        }

        public void DrawTriangle(int side1 , int side2 , int side3)
        {
            Graphics Triangle = this.pictureBox1.CreateGraphics();
            

            Point p1 = new Point(pen_position_defaultX, pen_position_defaultY);
            Point p2 = new Point(side1, pen_position_defaultY);
            Point p3 = new Point(side2, side3);

            Point[] points = { p1, p2, p3 };

            if (fill)
            {
                Triangle.FillPolygon(Default_Brush, points);
            }
            else
            {
                Triangle.DrawPolygon(Default_Pen, points);

            }
            this.label17.Text = "Triangle Drawn";

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Validation valid = new  Validation(textBox1.Text,textBox2.Text);
            String[] error=valid.Error_Handling_Validation();

            this.label17.Text = error[0];
            this.label18.Text = error[1];


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        { 
        }

    }
}
