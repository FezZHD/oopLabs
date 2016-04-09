using System;
using System.Collections.Generic;
using System.Drawing;

namespace graphicEditor
{
    class MyRectanlge:Shape
    {
      

        public override void Draw(Graphics canvas)
        {
            int realHeight = (int)Math.Abs(_pointsList[0][1] - _pointsList[1][1]);
            int realWidth = (int)Math.Abs(_pointsList[0][0] - _pointsList[1][0]);
            realHeight *= -1;
            realWidth *= -1;
            canvas.DrawRectangle(new Pen(_brushColor, Thinkness), _pointsList[0][0], _pointsList[0][1], realWidth, realHeight);
        }

        

        public MyRectanlge(ushort pointsCount) : base(pointsCount)
        {
        }
    }
}
