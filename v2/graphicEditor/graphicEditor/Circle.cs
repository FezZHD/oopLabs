using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphicEditor
{
    class MyCircle:Shape
    {


        public override void Draw(Graphics graphics, List<uint[]> pointsList)
        {
            int diametr = (int)Math.Abs(pointsList[0][1] - pointsList[1][1]);
            diametr *= -1;
            graphics.DrawEllipse(new Pen(_brushColor, Thinkness), pointsList[0][0], pointsList[0][1], diametr, diametr);
        }


        public MyCircle(ushort pointsCount) : base(pointsCount)
        {

        }
    }
}
