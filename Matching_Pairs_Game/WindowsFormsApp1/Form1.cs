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
    public partial class matchingpairsgame : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!","!","A","A","O","O","C","C",
            "R","R","J","J","M","M","H","H",
        };

        public matchingpairsgame()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomnumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomnumber];

                    icons.RemoveAt(randomnumber);
                }
            }
        }
    }
}
