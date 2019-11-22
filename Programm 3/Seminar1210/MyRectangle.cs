using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Seminar1210
{
    class MyRectangle : MyFigure
    {
        public int width, height;

        public MyRectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics gr)
        {
            var pen1 = new Pen(Form1.MainColor, 2);
            gr.DrawRectangle(pen1, x, y, width, height);
        }

        public override bool IsOnFigure(int x, int y)
        {
            if (x > this.x && y > this.y && x < this.x + width && y < this.y + height)
                return true;
            else
                return false;
        }

        //the methods need are isinside and move, which are overrides
    }
}
