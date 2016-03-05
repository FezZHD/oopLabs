using System;

namespace graphicEditor
{
    class MyEllipse:MyCircle
    {
        private readonly uint verticalRadius;

        public MyEllipse(uint startPoint, uint horizontalRadius, uint verticalRadius) : base(startPoint,horizontalRadius)
        {
            this.verticalRadius = verticalRadius;
        }

        public override string Draw()
        {
           return "Ellipse ( Start point:" + _startPoint + "; Horizontal Radius :" + HorizontalRadius + "; Vertical Radius :" + verticalRadius + ");" + Environment.NewLine;
        }
    }
}
