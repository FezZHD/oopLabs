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
         
        }

       


        public Triangle(ushort pointsCount) : base(pointsCount)
        {
            
        }
     
    }
}
