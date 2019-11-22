using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Seminar1210
{
    class MyVagonCoal : MyVagon
    {
        Brush br = new SolidBrush(Color.Black);

        public MyVagonCoal(int x, int y, int width, int height) : base(x, y, width, height)
        {
        }

        public override void Draw(Graphics gr)
        {
            base.Draw(gr);
            gr.FillRectangle(br, x + 5, y - (height / 3), width - 10, height / 3);
        }
    }
}
