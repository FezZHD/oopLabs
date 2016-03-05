using System;

namespace graphicEditor
{
    class MyRectanlge:Shape
    {
        protected uint RectangleEnd { get; set; }
        private uint SecondPoint;
        private uint ThirdPoint;
        public MyRectanlge (uint startPoint , uint secondPoint, uint thirdPoint ,uint rectangleEnd ) : base (startPoint)
        {
            SecondPoint = secondPoint;
            ThirdPoint = thirdPoint;
            RectangleEnd = rectangleEnd;
        }

        public override string Draw()
        {
            return "Rectangle (" + _startPoint + " ," + SecondPoint + " ," + ThirdPoint + " ," + RectangleEnd + ");" + Environment.NewLine;
        }
    }
}
