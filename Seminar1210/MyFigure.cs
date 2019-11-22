using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Seminar1210
{
    class MyFigure
    {
        public int x;
        public int y;

        public virtual void Draw(Graphics gr)
        {
        }

        public virtual bool IsOnFigure(int x, int y) 
        {
            bool is_inside = true;
            return is_inside;
        }

        public virtual void Move(int x, int y)
        {
        }
    }
}
