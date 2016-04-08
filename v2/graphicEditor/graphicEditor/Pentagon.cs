using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace graphicEditor
{
    class Pentagon:Shape   
    {
        public override void Draw(Graphics canvas, List<uint[]> pointsList)
        {
            canvas.DrawLine(new Pen(_brushColor, Thinkness), pointsList[0][0], pointsList[0][1], pointsList[1][0], pointsList[1][1]);
            canvas.DrawLine(new Pen(_brushColor, Thinkness), pointsList[1][0], pointsList[1][1], pointsList[2][0], pointsList[2][1]);
            canvas.DrawLine(new Pen(_brushColor, Thinkness), pointsList[2][0], pointsList[2][1], pointsList[3][0], pointsList[3][1]);
            canvas.DrawLine(new Pen(_brushColor, Thinkness), pointsList[3][0], pointsList[3][1], pointsList[4][0], pointsList[4][1]);
            canvas.DrawLine(new Pen(_brushColor, Thinkness), pointsList[4][0], pointsList[4][1], pointsList[0][0], pointsList[0][1]);

        }


        public Pentagon(ushort pointsCount) : base(pointsCount)
        {
            
        }
    }
}
