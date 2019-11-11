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
        bool isOperatorclick = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void click_button(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" || (isOperatorclick))
                resultBox.Clear();

            isOperatorclick = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!resultBox.Text.Contains("."))
                    resultBox.Text = resultBox.Text + button.Text;
            }
            else               
                resultBox.Text = resultBox.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultvalue != 0)
            {
                equalBtn.PerformClick();
                operatorclick = button.Text;
                isOperatorclick = true;
            }
            else
            {
                operatorclick = button.Text;
                resultvalue = Double.Parse(resultBox.Text);
                isOperatorclick = true;
            }
            operatorclick = button.Text;
            resultvalue = Double.Parse(resultBox.Text);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            resultvalue = 0;
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            switch (operatorclick)
            {
                case "+":
                    resultBox.Text = (resultvalue + Double.Parse(resultBox.Text)).ToString();
                    break;
                case "-":
                    resultBox.Text = (resultvalue - Double.Parse(resultBox.Text)).ToString();
                    break;
                case "X":
                    resultBox.Text = (resultvalue * Double.Parse(resultBox.Text)).ToString();
                    break;
                case "÷":
                    resultBox.Text = (resultvalue / Double.Parse(resultBox.Text)).ToString();
                    break;
                default:
                    break;

            }
        }
    }
}
