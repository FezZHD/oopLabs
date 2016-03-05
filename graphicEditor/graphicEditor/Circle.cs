using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphicEditor
{
    class MyCircle:Figure
    {
        protected uint StartPoint;
        protected uint HorizontalRadius;

       public MyCircle(uint startPoint , uint horizontalRadius)
        {
            StartPoint = startPoint;
            HorizontalRadius = horizontalRadius;
        }

        public override string Draw()
        {
            return "Circle ( Start point:" + StartPoint + "; Radius :" + HorizontalRadius + ")" + Environment.NewLine;
        }
    }
}
