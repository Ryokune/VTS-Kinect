using System;
using System.Windows.Forms;

namespace VTS_Kinect
{
    public partial class Form1 : Form
    {

        private VTSHandler handler = new VTSHandler();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            handler.Close();
        }
    }
}
