using System;

namespace graphicEditor
{
     class Line:Figure
    {
        protected uint StartPoint { get; private set; }
        protected uint EndPoint { get; private set; }
        
        internal Line(uint start, uint end)
        {
            StartPoint = start;
            EndPoint = end;
        }

         public override string Draw()
         {
            return "Line (" + StartPoint + " ," + EndPoint + ");" + Environment.NewLine;
         }
    }
}
