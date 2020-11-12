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
        }

        public void Clear()
        {

            this.label18.Text = "";
            this.label17.Text = "";
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.pictureBox1.ResetText();
        }

        public void Reset()
        {
            Clear();
        }


        public void Validation()
        {
            String validation_Text = "**This text feild is empty**";


            if (this.textBox1.Text=="" && this.textBox2.Text!="")
            {
                this.label17.Text = validation_Text;
                this.label18.Text = "";
                String comm = this.textBox2.Text.ToLower();
                if (comm=="clear")
                {
                    Clear();
                }
            }
            else if(this.textBox2.Text=="" && this.textBox1.Text != "")
            {
                this.label18.Text = validation_Text;
                this.label17.Text = "";
            }
            else if(this.textBox2.Text == "" && this.textBox1.Text == "")
            {
                this.label18.Text = validation_Text;
                this.label17.Text = validation_Text;
            }
            else if (this.textBox2.Text != "" && this.textBox1.Text != "")
            {
                this.label18.Text = "";
                this.label17.Text = "";

                Command_Implementation(this.textBox1.Text, this.textBox2.Text);
            }


        }

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
                Clear();
            }
            else if (command == "")
            {
                Reset();
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

            }
            else if (code[0] == "circle")
            {

            }
            else if (code[0] == "triangle")
            {

            }
            else if (code[0] == "pen")
            {

            }
            else if (code[0] == "fill")
            {

            }

            else
            {
                this.label17.Text = "**Program dont have a " + code[0] + " method**";
            }
        
        }


        public void MoveTo(int point1, int point2)
        {

        }

        public void DrawTo(int point1, int point2)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

    }
}
