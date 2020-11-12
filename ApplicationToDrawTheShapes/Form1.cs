using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        String validation_Text = "**This text feild is empty**";


        public void validation()
        {

            if (this.textBox1.Text=="" && this.textBox2.Text!="")
            {
                this.label17.Text = validation_Text;
                this.label18.Text = "";
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
            }


        }
        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validation();           
        }
    }
}
