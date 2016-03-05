using System;

namespace graphicEditor
{
    class Triangle:Shape
    {
        protected uint FigureEnd { get; set; }
        private uint _secondPoint;
        public Triangle(uint start, uint secondPoint, uint figureEnd) : base(start)
        {
            _secondPoint = secondPoint;
            FigureEnd = figureEnd;
        }


        public override string Draw()
        {
            return "Triangle (" + _startPoint + " ," + _secondPoint + " ," + FigureEnd + ");" + Environment.NewLine;
        }
    }
}
