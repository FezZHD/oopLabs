using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace graphicEditor
{
     class Line:Shape
    {     
         public override void Draw(Graphics graphics, List<uint[]> pointsList)
         {
            graphics.DrawLine(new Pen(_brushColor, Thinkness),pointsList[0][0] , pointsList[0][1], pointsList[1][0], pointsList[1][1]);
         }



         public Line(ushort pointsCount) : base(pointsCount)
         {
         }
    }
}
