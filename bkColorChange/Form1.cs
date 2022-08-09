using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bkColorChange
{
    public partial class Form1 : Form
    {
        public override System.Drawing.Color BackColor { get;set; }

        public Form1()
        {
            InitializeComponent();
            //this.BackColor = System.Drawing.Color.Green;
            hideCheck();
            
        }

        private void btnBkClrChange_Click(object sender, EventArgs e)
        {
            panelClr.BackColor = System.Drawing.Color.Empty;
            hideCheck();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideCheck();
            panelClr.BackColor = System.Drawing.Color.Black;
            btnBlack.Image = bkColorChange.Properties.Resources.smallCheckIcon;
        }

        private void btnOliveDrab_Click(object sender, EventArgs e)
        {
            hideCheck();
            btnOliveDrab.Image = bkColorChange.Properties.Resources.smallCheckIcon;
            panelClr.BackColor = System.Drawing.Color.OliveDrab;
        }

        private void btnTeal_Click(object sender, EventArgs e)
        {
            hideCheck();
            btnTeal.Image = bkColorChange.Properties.Resources.smallCheckIcon;
            panelClr.BackColor = System.Drawing.Color.Teal;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideCheck();
            btnPurple.Image = bkColorChange.Properties.Resources.smallCheckIcon;
            panelClr.BackColor = System.Drawing.Color.Purple;
        }

        private void btnDSGray_Click(object sender, EventArgs e)
        {
            hideCheck();
            btnDSGray.Image = bkColorChange.Properties.Resources.smallCheckIcon;
            panelClr.BackColor = System.Drawing.Color.DarkSlateGray;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hideCheck();
            colRand();
        }

        public void colRand() {
            var rand = new Random();
            int r1 = rand.Next(0, 255);
            int r2 = rand.Next(0, 255);
            int r3 = rand.Next(0, 255);

            panelClr.BackColor = Color.FromArgb(r1, r2, r3);
            this.Invalidate();

            MessageBox.Show("The color values selected at random are: " + r1 + ", " + r2 + ", " + r3);

            //return panelClr.BackColor.ToKnownColor();
        }

        public void hideCheck() {
            btnBlack.Image = null;
            btnOliveDrab.Image = null;
            btnTeal.Image = null;
            btnPurple.Image = null;
            btnDSGray.Image = null;
        }
    }
}
