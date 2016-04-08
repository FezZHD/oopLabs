using System;
using System.Collections.Generic;
using System.Drawing;

namespace graphicEditor
{
    class MyRectanlge:Shape
    {
      

        public override void Draw(Graphics canvas, List<uint[]> pointsList)
        {
          
        }

        

        public MyRectanlge(ushort pointsCount) : base(pointsCount)
        {
        }
    }
}
