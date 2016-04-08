using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace graphicEditor
{
    class Pentagon:Shape   
    {
        public override void Draw(Graphics graphics, List<uint[]> pointsList)
        {
            
        }

        public  void AddToList(ushort[] pointsArray)
        {
           
        }

        public Pentagon(ushort pointsCount) : base(pointsCount)
        {
        }
    }
}
