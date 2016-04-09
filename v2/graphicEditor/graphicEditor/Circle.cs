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


        public override void Draw(Graphics graphics)
        {
            int diametr = (int)Math.Abs(_pointsList[0][1] - _pointsList[1][1]);
            diametr *= -1;
            graphics.DrawEllipse(new Pen(_brushColor, Thinkness), _pointsList[0][0], _pointsList[0][1], diametr, diametr);
        }


        public MyCircle(ushort pointsCount) : base(pointsCount)
        {

        }
    }
}
