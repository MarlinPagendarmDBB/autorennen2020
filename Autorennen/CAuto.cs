using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Autorennen
{
    public class CAuto : CFahrzeug
    {
        /// <summary>
        /// Kontruktor CAuto
        /// </summary>
        /// <param name="Y">y-Koordinate des Autos</param>
        /// <param name="Farbe">Farbe des Autos</param>
        public CAuto(int Y, Color Farbe) : base(Y, Farbe, 55, 30, 0.5, 1.5) {}

        public string Tacho
        {
            get
            {
                return (10*geschwindigkeit).ToString("000");
            }
        }

        public void Hupen()
        {
            SoundPlayer player = new SoundPlayer("sounds//hupe.wav");
            player.Play();
            AndereSchrecken();
        }

        protected override void zeichneMich(Graphics g)
        {
            Pen p = new Pen(Farbe, 2);
            SolidBrush b = new SolidBrush(Color.Black);
            g.FillRectangle(new SolidBrush(Color.Black), X + 5, Y + 2, 10, 8);
            g.FillRectangle(Brushes.Black, X + 5, Y + 35, 10, 8);
            g.FillRectangle(b, X + 40, Y + 5, 10, 8);
            g.FillRectangle(b, X + 40, Y + 32, 10, 8);
            g.DrawLine(p, X + 10, Y + 10, X + 10, Y + 15);
            g.DrawLine(p, X + 10, Y + 30, X + 10, Y + 35);
            g.DrawLine(p, X + 45, Y + 13, X + 45, Y + 18);
            g.DrawLine(p, X + 45, Y + 27, X + 45, Y + 32);
            b.Color = Farbe;
            g.FillPolygon(b, new Point[] { new Point(X + 0, Y + 15),
                                           new Point(X + 35, Y + 15),
                                           new Point(X + 55, Y + 20),
                                           new Point(X + 55, Y + 25),
                                           new Point(X + 35, Y + 30),
                                           new Point(X + 0, Y + 30),
                                           new Point(X + 0, Y + 15) });
            b.Color = Color.White;
            g.FillEllipse(b, X + 21, Y + 16, 12, 12);
        }
    }
}
