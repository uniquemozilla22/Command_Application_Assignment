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
    public partial class ShapeCoder : Form
    {
        public static Graphics g;

        public ShapeCoder()
        {
            InitializeComponent();
            this.textBox1.Text = "";
            this.textBox2.Text = "";

        }
        public static int pen_position_defaultX = 10;
        public static int pen_position_defaultY = 10;
        public static bool fill = false;
        public static Pen Default_Pen = new Pen(Color.White);
        public static SolidBrush Default_Brush = new SolidBrush(Color.White);

     
        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comm = this.textBox2.Text.ToLower().Trim();
                if(comm=="run"){

                g = this.pictureBox1.CreateGraphics();

                Validation valid = new Validation(textBox1.Text, textBox2.Text);
                String[] error = valid.Error_Handling_Validation();
                this.label17.Text = error[0];
                this.label18.Text = error[1];
            }
                else if (comm=="clear")
            {
                Clear();
            }
                else if(comm=="reset")
            {
                Reset();
            }
            else
            {
                label18.Text = "**Please enter a valid command**";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            label17.Text="";
            label18.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
        public void Reset()
        {
            this.Clear();
            pictureBox1.Refresh();
            g.ResetTransform();

        }

    }
}
