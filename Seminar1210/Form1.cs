using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar1210
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainColor = Color.Black;
        }

        public static Color MainColor = new Color();

        enum FigureName
        {
            Rectangle,
            Circle,
            Vagon,
            Train
        }

        FigureName figureid = FigureName.Rectangle;

        Graphics gr;
        
        int p1x, p1y, p2x, p2y, width, height;

        List<MyFigure> figs = new List<MyFigure>();

        private void RectBtn_Click(object sender, EventArgs e)
        {
            figureid = FigureName.Rectangle;
        }

        private void CircleBtn_Click(object sender, EventArgs e)
        {
            figureid = FigureName.Circle;
        }

        private void vagbtn_Click(object sender, EventArgs e)
        {
            figureid = FigureName.Vagon;
        }

        private void trainBtn_Click(object sender, EventArgs e)
        {
            figureid = FigureName.Train;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            figs.Clear();
            panel1.Refresh();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            p1x = e.X;
            p1y = e.Y;

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            p2x = e.X;
            p2y = e.Y;
            DrawFigure(figureid);
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                MainColor = colorDialog1.Color;
            colorBtn.BackColor = MainColor;
        }

        void DrawFigure(FigureName name)
        {
            gr = panel1.CreateGraphics();

            switch (name)
            {
                case FigureName.Rectangle:

                    MyFigure rect;
                    Calculate(p1x, p1y, p2x, p2y);
                    rect = new MyRectangle(p1x, p1y, width, height);
                    figs.Add(rect);
                    rect.Draw(gr);

                    break;

                case FigureName.Circle:

                    double r = Math.Sqrt(Math.Pow(p2x - p1x, 2) + Math.Pow(p2y - p1y, 2));
                    MyFigure circ = new MyCircle(p1x, p1y, r);
                    figs.Add(circ);
                    circ.Draw(gr);

                    break;

                case FigureName.Vagon:

                    MyFigure vagon;
                    Calculate(p1x, p1y, p2x, p2y);
                    vagon = new MyVagon(p1x, p1y, width, height);
                    figs.Add(vagon);
                    vagon.Draw(gr);

                    break;

                case FigureName.Train:

                    MyTrain train;
                    Calculate(p1x, p1y, p2x, p2y);
                    train = new MyTrain(p1x, p1y, width, height, (int)vagcount.Value);
                    figs.Add(train);
                    train.Draw(gr);

                    break;
            }
        }

        void Calculate(int x1, int y1, int x2, int y2)
        {
            if (x2 < x1 && y2 < y1)
            {
                width = Math.Abs(p2x - p1x);
                height = Math.Abs(p2y - p1y);
                p1x = p2x;
                p1y = p2y;
            }
            else if (x1 < x2 && y1 > y2)
            {
                width = Math.Abs(p2x - p1x);
                height = Math.Abs(p2y - p1y);
                p1y = p2y;
            }
            else if (x1 > x2 && y1 < y2)
            {
                width = Math.Abs(p2x - p1x);
                height = Math.Abs(p2y - p1y);
                p1x = p2x;
            }
            else
            {
                width = Math.Abs(p2x - p1x);
                height = Math.Abs(p2y - p1y);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (MyFigure fig in figs)
            {
                fig.Draw(gr);
            }
        }
    }
}
