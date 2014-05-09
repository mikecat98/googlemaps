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
        string streetadd, cityname;
        int zoom = 11;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            zoom = trackBar1.Value;
            streetadd = textBox1.Text;
            cityname = textBox2.Text;
            WebRequest requestPic = WebRequest.Create("http://maps.googleapis.com/maps/api/staticmap?center=" + streetadd + "," + cityname + "&zoom="+zoom+"&size=435x350&sensor=false");
            WebResponse repsonsePic = requestPic.GetResponse();
            Image map = Image.FromStream(repsonsePic.GetResponseStream());
            pictureBox1.Image = map;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            streetadd = textBox1.Text;
            cityname = textBox2.Text;
            WebRequest requestPic = WebRequest.Create("http://maps.googleapis.com/maps/api/staticmap?center=" + streetadd + "," + cityname + "&zoom=11&size=435x350&sensor=false");
            WebResponse repsonsePic = requestPic.GetResponse();
            Image map = Image.FromStream(repsonsePic.GetResponseStream());
            pictureBox1.Image = map;
            requestPic = WebRequest.Create("http://maps.googleapis.com/maps/api/streetview?size=435x350&location=" + streetadd + "," + cityname + "&heading=235&sensor=false");
            repsonsePic = requestPic.GetResponse();
            map = Image.FromStream(repsonsePic.GetResponseStream());
            pictureBox2.Image = map;

        }
    }
}
