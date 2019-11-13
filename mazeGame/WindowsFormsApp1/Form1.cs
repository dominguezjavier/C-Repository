using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations!");
            Close();
        }

        private void MoveToStart()
        {
            Point startingpoint = panel1.Location;
            startingpoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingpoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
