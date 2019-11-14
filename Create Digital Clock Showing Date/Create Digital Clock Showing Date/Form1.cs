using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create_Digital_Clock_Showing_Date
{
    public partial class clock : Form
    {
        public clock()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hourMinuteLabel.Text = DateTime.Now.ToString("HH:mm");
            secondsLabel.Text = DateTime.Now.ToString("ss");
            dateLabel.Text = DateTime.Now.ToString("MMM:dd:yyyy");
            weekDayLabel.Text = DateTime.Now.ToString("dddd");
        }

        private void clock_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
