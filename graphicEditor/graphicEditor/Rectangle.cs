using System;

namespace graphicEditor
{
    internal class Triangle:Line
    {
        protected uint FigureEnd { get; set; }
        internal Triangle(uint start, uint end, uint figureEnd) : base(start, end)
        {
            FigureEnd = figureEnd;
        }

        internal string DrawTriangle()
        {
            return "Triangle (" + StartPoint + " ," + EndPoint + " ," + FigureEnd + ");" + Environment.NewLine;
        }
    }
}
