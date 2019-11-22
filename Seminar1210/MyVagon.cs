using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1210
{
    class MyVagon : MyRectangle
    {
        MyCircle wheell;
        MyCircle wheelr;

        public MyVagon(int x, int y, int width, int height) : base(x, y , width, height)
        {
            int k = (width + height) / 10;
            wheell = new MyCircle(x + (width / 4), y + height + k, k);
            wheelr = new MyCircle(x + width - (width / 4), y + height + k, k);
        }

        public override void Draw(Graphics gr)
        {
            base.Draw(gr);
            wheell.Draw(gr);
            wheelr.Draw(gr);
        }
    }
}
