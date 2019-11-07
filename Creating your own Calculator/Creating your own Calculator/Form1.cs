using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creating_your_own_Calculator
{
    public partial class Form1 : Form
    {
        Double resultvalue = 0;
        string operatorclick = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void click_button(object sender, EventArgs e)
        {
            if (resultBox.Text == "0")
                resultBox.Clear();

            Button button = (Button)sender;
            resultBox.Text = resultBox.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatorclick = button.Text;
            resultvalue = Double.Parse(resultBox.Text);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            resultvalue = 0;
        }
    }
}
