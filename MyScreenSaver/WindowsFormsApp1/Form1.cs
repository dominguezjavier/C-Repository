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
    public partial class frmScSaver : Form
    {
        List<Image> BGImages = new List<Image>();
        List<BritPic> BritPics = new List<BritPic>();
        Random rand = new Random();

        class BritPic        {
            public int PicNum;
            public float x;
            public float y;
            public float speed;
        }

        public frmScSaver()
        {
            InitializeComponent();
        }

        private void frmScSaver_Load(object sender, EventArgs e)
        {

        }

        private void frmScSaver_KeyDown(object sender, KeyEventArgs e)
        {
           Close();
        }
    }
}
