using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace graphicEditor
{
    class Pentagon:Shape   
    {
        public override void Draw(Graphics canvas)
        {
            canvas.DrawLine(new Pen(_brushColor, Thinkness), _pointsList[0][0], _pointsList[0][1], _pointsList[1][0], _pointsList[1][1]);
            canvas.DrawLine(new Pen(_brushColor, Thinkness), _pointsList[1][0], _pointsList[1][1], _pointsList[2][0], _pointsList[2][1]);
            canvas.DrawLine(new Pen(_brushColor, Thinkness), _pointsList[2][0], _pointsList[2][1], _pointsList[3][0], _pointsList[3][1]);
            canvas.DrawLine(new Pen(_brushColor, Thinkness), _pointsList[3][0], _pointsList[3][1], _pointsList[4][0], _pointsList[4][1]);
            canvas.DrawLine(new Pen(_brushColor, Thinkness), _pointsList[4][0], _pointsList[4][1], _pointsList[0][0], _pointsList[0][1]);

        }


        public Pentagon(ushort pointsCount) : base(pointsCount)
        {
            
        }
    }
}
