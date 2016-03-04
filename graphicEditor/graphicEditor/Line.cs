using System;

namespace graphicEditor
{
    internal class Line
    {
        protected uint StartPoint { get; private set; }
        protected uint EndPoint { get; private set; }

        internal Line(uint start, uint end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        internal string DrawLine()
        {
            return "Line (" + StartPoint + " ," + EndPoint + ");" + Environment.NewLine;
        }
    }
}
