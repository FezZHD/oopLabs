using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace graphicEditor
{
    class MyEllipse:MyCircle
    {
     

        public override void Draw(Graphics graphics)
        {
            int realHeight = (int) Math.Abs(_pointsList[0][1] - _pointsList[1][1]);
            int realWidth =  (int) Math.Abs(_pointsList[0][0] - _pointsList[1][0]);
            realHeight *= -1;
            realWidth *= -1;
            graphics.DrawEllipse(new Pen(_brushColor, Thinkness), _pointsList[0][0], _pointsList[0][1], realWidth, realHeight);
        }

        public MyEllipse(ushort pointsCount) : base(pointsCount)
        {
        }
    }
}
