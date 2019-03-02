using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        public bool start = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clock.Interval = 1000;
        }

        private void buttClick(object sender, EventArgs e)
        {
            if (start == false)
            {
                clock.Start();
                start = true;
            }
            else
            {
                clock.Stop();
                start = false;
            }
        }

        private void Clock1Sec(object sender, EventArgs e)
        {
            string var = DateTime.Now.ToString();
            label1.Text = var;
        }
    }
}
