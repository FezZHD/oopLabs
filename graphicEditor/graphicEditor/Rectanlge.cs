using System;

namespace graphicEditor
{
    class MyRectanlge:Triangle
    {
        protected uint RectangleEnd { get; set; }
        public MyRectanlge (uint start , uint end, uint figureEnd ,uint rectangleEnd ) : base (start , end ,figureEnd)
        {
            RectangleEnd = rectangleEnd;
        }

        public override string Draw()
        {
            return "Rectangle (" + StartPoint + " ," + EndPoint + " ," + FigureEnd + " ," + RectangleEnd + ");" + Environment.NewLine;
        }
    }
}
