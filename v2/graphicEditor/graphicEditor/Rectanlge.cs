using System;
using System.Collections.Generic;
using System.Drawing;

namespace graphicEditor
{
    class MyRectanlge:Shape
    {
      

        public override void Draw(Graphics canvas, List<uint[]> pointsList)
        {
            int realHeight = (int)Math.Abs(pointsList[0][1] - pointsList[1][1]);
            int realWidth = (int)Math.Abs(pointsList[0][0] - pointsList[1][0]);
            realHeight *= -1;
            realWidth *= -1;
            canvas.DrawRectangle(new Pen(_brushColor, Thinkness), pointsList[0][0], pointsList[0][1], realWidth, realHeight);
        }

        

        public MyRectanlge(ushort pointsCount) : base(pointsCount)
        {
        }
    }
}
