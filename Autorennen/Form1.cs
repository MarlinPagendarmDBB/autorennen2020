using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autorennen
{
    public partial class Form1 : Form
    {
        CAuto auto;
        CFahrrad fahrrad;
        Graphics graphics;

        public Form1()
        {
            InitializeComponent();
            graphics = pnlFahrbahn.CreateGraphics();
            auto = new CAuto(10, Color.Red);
            fahrrad = new CFahrrad(110, Color.Blue);
            fahrrad.Schreck += auto.OnSchreck;
            auto.Schreck += fahrrad.OnSchreck;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics.FillRectangle(new SolidBrush(pnlFahrbahn.BackColor),
                0, 0, pnlFahrbahn.Width, pnlFahrbahn.Height);
            auto.Anzeigen(graphics);
            fahrrad.Anzeigen(graphics);
            lblTacho.Text = auto.Tacho;

        }

        private void btnHupe_Click(object sender, EventArgs e)
        {
            auto.Hupen();
        }

        private void btnBremse_Click(object sender, EventArgs e)
        {
            auto.Bremsen();
        }

        private void btnGas_Click(object sender, EventArgs e)
        {
            auto.Beschleunigen();
        }

        private void btnKlingel_Click(object sender, EventArgs e)
        {
            fahrrad.Klingeln();
        }

        private void btnFahrradbremse_Click(object sender, EventArgs e)
        {
            fahrrad.Bremsen();
        }

        private void btnTreten_Click(object sender, EventArgs e)
        {
            fahrrad.Beschleunigen();
        }

        private void pnlFahrbahn_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X.ToString() + "/" + e.Y.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
