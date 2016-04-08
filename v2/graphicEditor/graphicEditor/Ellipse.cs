using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace graphicEditor
{
    class MyEllipse:MyCircle
    {
     

        public override void Draw(Graphics graphics, List<uint[]> pointsList)
        {
            int realHeight = (int) Math.Abs(pointsList[0][1] - pointsList[1][1]);
            int realWidth =  (int) Math.Abs(pointsList[0][0] - pointsList[1][0]);
            realHeight *= -1;
            realWidth *= -1;
            graphics.DrawEllipse(new Pen(_brushColor, Thinkness), pointsList[0][0], pointsList[0][1], realWidth, realHeight);
        }

        public MyEllipse(ushort pointsCount) : base(pointsCount)
        {
        }
    }
}
