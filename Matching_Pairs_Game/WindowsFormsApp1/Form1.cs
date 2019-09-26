/*Javier Dominguez
 * Reno Technology Academy
 * CIS109; Coding in C# for imbedded systems
 * Udemy 17 Beginner C#
 * project 1; create a matching pair game
 */

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
        Random random = new Random();

        List<string> icons = new List<string>()
        {
            "!","!","A","A","O","O","C","C",
            "R","R","J","J","M","M","H","H",
        };

        Label firstclicked, secondclicked;

        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void label_Click(object sender, EventArgs e)
        {
            if (firstclicked != null && secondclicked != null)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel == null)
                return;
            if (clickedLabel.ForeColor == Color.Black)
                return;
            if (firstclicked == null)
            {
                firstclicked = clickedLabel;
                firstclicked.ForeColor = Color.Black;
                return;
            }

            secondclicked = clickedLabel;
            secondclicked.ForeColor = Color.Black;

            checkForwinner();

            if (firstclicked.Text == secondclicked.Text)
            {
                firstclicked = null;
                secondclicked = null;
            }
            else
                timer1.Start();

        }

        private void checkForwinner()
        {
            Label label;
            for(int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                if (label != null && label.ForeColor == label.BackColor)
                    return;
            }

            MessageBox.Show("You matched all the icons! Congrats!");
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstclicked.ForeColor = firstclicked.BackColor;
            secondclicked.ForeColor = secondclicked.BackColor;

            firstclicked = null;
            secondclicked = null;

        }

        private void AssignIconsToSquares()
        {
            Label label;
            int randomNumber;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                {
                    label = (Label)tableLayoutPanel1.Controls[i];
                    randomNumber = random.Next(0, icons.Count);
                    label.Text = icons[randomNumber];

                    icons.RemoveAt(randomNumber);
                }
                else
                    continue;
            }
        }
    }
}
