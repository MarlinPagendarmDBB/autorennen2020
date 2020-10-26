using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Autorennen
{
    public abstract class CFahrzeug
    {
        #region Attribute
        private double x, y; // in Pixeln, aber trotzdem als double
        private Color farbe;
        private double maxGeschwindigkeit, beschleunigung, bremskraft;
        protected double geschwindigkeit; // für Tacho bei CAuto
        private int laenge; // Länge des Fahrzeugs in Pixeln
        #endregion

        #region Konstruktor
        public CFahrzeug(int Y, Color Farbe, int Laenge,
            double MaxGeschwindigkeit, double Beschleunigung,
            double Bremskraft)
        {
            x = 100 - Laenge;
            y = Y;
            farbe = Farbe; // im Zweifel this.farbe = Farbe;
            maxGeschwindigkeit = MaxGeschwindigkeit;
            beschleunigung = Beschleunigung;
            bremskraft = Bremskraft;
            geschwindigkeit = 0;
            laenge = Laenge;
        }
        #endregion

        #region Eigenschaften
        public int X
        {
            get
            {
                return (int)x;
            }
            // kein set => X kann von außen nur gelesen, aber nicht
            // gesetzt werden.
        }

        public int Y
        {
            get
            {
                return (int)y;
            }
        }

        public Color Farbe
        {
            get
            {
                return farbe;
            }
        }
        #endregion

        #region Methoden
        public void Beschleunigen()
        {
            geschwindigkeit += beschleunigung;
            if (geschwindigkeit > maxGeschwindigkeit)
            {
                geschwindigkeit = maxGeschwindigkeit;
            }
        }

        public void Bremsen()
        {
            geschwindigkeit -= bremskraft;
            if (geschwindigkeit < 0)
            {
                geschwindigkeit = 0;
            }
        }

        public void Anzeigen(Graphics g)
        {
            x += geschwindigkeit;
            if (x > g.VisibleClipBounds.Width)
            {
                x = -laenge;
            }
            zeichneMich(g);
        }

        protected abstract void zeichneMich(Graphics g);
        #endregion

        #region Ereignisse
        public event EventHandler<Point> Schreck;

        public void OnSchreck(object sender, Point P)
        {
            if (Math.Sqrt(Math.Pow(X - P.X,2) + Math.Pow(Y - P.Y,2)) <= 150)
            {
                Bremsen();
            }
        }

        protected void AndereSchrecken()
        {
            Schreck(this, new Point(X, Y));
        }

        #endregion

    }
}
