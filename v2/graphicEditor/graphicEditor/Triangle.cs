using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace graphicEditor
{
    class Triangle:Shape
    {   


        public override void Draw(Graphics canvas)
        {
            canvas.DrawLine(new Pen(_brushColor, Thinkness),_pointsList[0][0],_pointsList[0][1],_pointsList[1][0],_pointsList[1][1]);
            canvas.DrawLine(new Pen(_brushColor, Thinkness), _pointsList[1][0], _pointsList[1][1], _pointsList[2][0], _pointsList[2][1]);
            canvas.DrawLine(new Pen(_brushColor, Thinkness), _pointsList[2][0], _pointsList[2][1], _pointsList[0][0], _pointsList[0][1]);

        }

       


        public Triangle(ushort pointsCount) : base(pointsCount)
        {
            
        }
     
    }
}
