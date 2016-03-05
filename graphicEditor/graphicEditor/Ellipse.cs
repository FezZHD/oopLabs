using System;

namespace graphicEditor
{
    class MyEllipse:MyCircle
    {
        protected uint VerticalRadius;

        public MyEllipse(uint startPoint, uint horizontalRadius, uint verticalRadius) : base(startPoint,horizontalRadius)
        {
            VerticalRadius = verticalRadius;
        }

        public override string Draw()
        {
           return "Ellipse ( Start point:" + StartPoint + "; Horizontal Radius :" + HorizontalRadius + "; Vertical Radius :" + VerticalRadius + ");" + Environment.NewLine;
        }
    }
}
