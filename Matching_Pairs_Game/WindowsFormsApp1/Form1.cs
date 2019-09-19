/*Javier Dominguez
 * Reno Technology Academy
 * CIS109; Coding in C# for imbedded systems
 * Udemy 17 Beginner C#
 * project 1; create a matching pair game
 */

System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matchingpairsgame
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
        }
    }
}
