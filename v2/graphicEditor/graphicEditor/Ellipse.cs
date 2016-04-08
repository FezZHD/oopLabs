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
           graphics.DrawEllipse(new Pen(_brushColor,3),pointsList[0][0], pointsList[0][1], pointsList[1][0],pointsList[1][1]);
        }

        public MyEllipse(ushort pointsCount) : base(pointsCount)
        {
        }
    }
}
