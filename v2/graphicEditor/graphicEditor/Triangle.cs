using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace graphicEditor
{
    class Triangle:Shape
    {   


        public override void Draw(Graphics canvas, List<uint[]> pointsList)
        {
            canvas.DrawLine(new Pen(_brushColor,3),pointsList[0][0],pointsList[0][1],pointsList[1][0],pointsList[1][1]);
            canvas.DrawLine(new Pen(_brushColor, 3), pointsList[1][0], pointsList[1][1], pointsList[2][0], pointsList[2][1]);
            canvas.DrawLine(new Pen(_brushColor, 3), pointsList[2][0], pointsList[2][1], pointsList[0][0], pointsList[0][1]);

        }

       


        public Triangle(ushort pointsCount) : base(pointsCount)
        {
            
        }
     
    }
}
