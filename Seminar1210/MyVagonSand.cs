using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Seminar1210
{
    class MyVagonSand : MyVagon
    {
        Brush br = new SolidBrush(Color.SandyBrown);
        Point[] points = new Point[3];

        public MyVagonSand(int x, int y, int width, int height) : base(x, y, width, height)
        {
        }

        public override void Draw(Graphics gr)
        {
            base.Draw(gr);
            points[0] = new Point(x + 5, y);
            points[1] = new Point(x + width / 2, y - (height / 3));
            points[2] = new Point(x + (width - 5), y);
            gr.FillPolygon(br, points);
        }
    }
}
