using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace Autorennen
{
    public class CFahrrad : CFahrzeug
    {

        public CFahrrad(int Y, Color Farbe) : base(Y, Farbe, 30, 5, 0.2, 1.0) { }

        public void Klingeln()
        {
            SoundPlayer player = new SoundPlayer("sounds//klingel.wav");
            player.Play();
            AndereSchrecken();
        }


        protected override void zeichneMich(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawLine(p, X, Y + 5, X + 30, Y + 5);
            g.DrawLine(p, X+25, Y, X + 25, Y + 10);
            SolidBrush b = new SolidBrush(Farbe);
            g.FillRectangle(b, X + 10, Y + 1, 15, 8);
            b.Color = Color.Yellow;
            g.FillEllipse(b, X + 20, Y+3, 4, 4);
        }
    }
}
