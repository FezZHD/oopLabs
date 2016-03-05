using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphicEditor
{
    class MyCircle:Shape
    {

       protected readonly uint HorizontalRadius;

       public MyCircle(uint startPoint , uint horizontalRadius): base (startPoint)
        {
            HorizontalRadius = horizontalRadius;
        }

        public override string Draw()
        {
            return "Circle ( Start point:" + _startPoint + "; Radius :" + HorizontalRadius + ")" + Environment.NewLine;
        }
    }
}
