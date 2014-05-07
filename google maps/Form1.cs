using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace google_maps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       double y=0;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "" + trackBar1.Value;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
