using System;

namespace graphicEditor
{
    class Pentagon:Shape   
    {
        private uint EndPentagon;
        private uint SecondPoint;
        private uint ThirdPoint;
        private uint FouthPoint;

        public Pentagon(uint startPoint, uint secondPoint, uint thirdPoint, uint fouthPoint, uint pentagonEnd): base (startPoint)
        {
            SecondPoint = secondPoint;
            ThirdPoint = thirdPoint;
            FouthPoint = fouthPoint;
            EndPentagon = pentagonEnd;
        }

        public override string Draw()
        {
            return "Pentagon (" + _startPoint + " ," + SecondPoint + " ," + ThirdPoint + " ," + FouthPoint +  "," + EndPentagon + ");" + Environment.NewLine;
        }
    }
}
