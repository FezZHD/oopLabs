using System;

namespace graphicEditor
{
    class Pentagon:MyRectanlge
    {
        private uint EndPentagon;

        public Pentagon(uint start, uint end, uint figureEnd, uint rectangleEnd, uint pentagonEnd): base(start, end, figureEnd, rectangleEnd)
        {
            EndPentagon = pentagonEnd;
        }

        public override string Draw()
        {
            return "Pentagon (" + StartPoint + " ," + EndPoint + " ," + FigureEnd + " ," + RectangleEnd +  "," + EndPentagon + ");" + Environment.NewLine;
        }
    }
}
