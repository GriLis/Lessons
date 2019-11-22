using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Seminar1210
{
    class MyCircle : MyFigure
    {
        int width, height;

        public MyCircle(int x1, int y1, double r)
        {
            x = x1 - (int)r;
            y = y1 - (int)r;
            width = 2*(int)r;
            height = 2*(int)r;
        }

        public override void Draw(Graphics gr)
        {
            var pen1 = new Pen(Form1.MainColor, 2);
            gr.DrawEllipse(pen1, x, y, width, height);
        }
    }
}
