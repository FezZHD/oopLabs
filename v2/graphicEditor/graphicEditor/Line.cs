using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace graphicEditor
{
     class Line:Shape
    {     
         public override void Draw(Graphics graphics)
         {
            graphics.DrawLine(new Pen(_brushColor, Thinkness),_pointsList[0][0] , _pointsList[0][1], _pointsList[1][0], _pointsList[1][1]);
         }



         public Line(ushort pointsCount) : base(pointsCount)
         {
         }
    }
}
