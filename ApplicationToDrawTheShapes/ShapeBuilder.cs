using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ApplicationToDrawTheShapes
{
    public class ShapeBuilder : From1
    {
        

        public void Clear()
        {

            this.label18.Text = "";
            this.label17.Text = "";
            this.textBox1.Text = "";
            this.textBox2.Text = "";

        }

        public void Reset()
        
            Clear();
            this.pictureBox1.Image = null;
        }
    }
}
