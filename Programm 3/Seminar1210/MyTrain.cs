using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Seminar1210
{
    class MyTrain : MyFigure
    {
        List<MyVagon> vagons = new List<MyVagon>();
        Random rnd = new Random();
        int id;

        public MyTrain(int x, int y, int width, int height, int count)
        {
            for (int i = 0; i < count; i++)
            {
                id = rnd.Next(0, 3);
                MyVagon vagon = new MyVagon(x + (i * width / count), y, width / count - 10, height);

                switch (id)
                {
                    case 1:

                        vagon = new MyVagonCoal(x + (i * width / count), y, width / count - 10, height);

                        break;

                    case 2:

                        vagon = new MyVagonSand(x + (i * width / count), y, width / count - 10, height);

                        break;
                }

                vagons.Add(vagon);
            }
        }

        public override void Draw(Graphics gr)
        {
            foreach (MyVagon vag in vagons)
            {
                vag.Draw(gr);
            }
        }
    }
}
