﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currencyConverter
{
    public partial class currencyConvert : Form
    {
        public currencyConvert()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.ofx.com/en-us/currency-converter/");
        }
    }
}
