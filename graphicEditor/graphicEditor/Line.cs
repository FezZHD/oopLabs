using System;

namespace graphicEditor
{
     class Line:Shape
    {

        protected uint EndPoint { get; private set; }
        
        public Line(uint start, uint end):base (start)
        {
            EndPoint = end;
        }

         public override string Draw()
         {
            return "Line (" + _startPoint + " ," + EndPoint + ");" + Environment.NewLine;
         }
    }
}
