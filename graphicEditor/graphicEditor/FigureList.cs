using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace graphicEditor
{
    class FigureList
    {
        private List<Shape> listFigure = new List<Shape>();

        public void AddFigure(Shape Shape)
        {
            listFigure.Add(Shape);
        }

        public void DrawList(TextBox box)
        {
            foreach (var Shape in listFigure)
            {
                box.Text += Shape.Draw() + Environment.NewLine;
            }
        }
    }
}
