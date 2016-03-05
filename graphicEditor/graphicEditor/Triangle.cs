using System;

namespace graphicEditor
{
    class Triangle:Line
    {
        protected uint FigureEnd { get; set; }
        public Triangle(uint start, uint end, uint figureEnd) : base(start, end)
        {
            FigureEnd = figureEnd;
        }


        public override string Draw()
        {
            return "Triangle (" + StartPoint + " ," + EndPoint + " ," + FigureEnd + ");" + Environment.NewLine;
        }
    }
}
