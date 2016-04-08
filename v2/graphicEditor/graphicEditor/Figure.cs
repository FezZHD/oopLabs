using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace graphicEditor
{
    public abstract class Shape
    {

        public ushort PointCounter { get; set; }

        public List<uint[]> _pointsList;
        public Color _brushColor { get; set; }
        public int Thinkness { get; set; }
        public abstract void Draw(Graphics canvas, List<uint[]> _pointsList);

        public virtual void AddToList(uint[] PointsArray)
        {
            _pointsList.Add(new [] {PointsArray[0], PointsArray[1]});
        }


        public Shape(ushort pointsCount)
        {
            _pointsList = new List<uint[]>();
            PointCounter = pointsCount;
       }

    }
}
