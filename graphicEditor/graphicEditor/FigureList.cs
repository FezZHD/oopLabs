using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace graphicEditor
{
    class FigureList
    {
        private List<Figure> listFigure = new List<Figure>();

        public void AddFigure(Figure figure)
        {
            listFigure.Add(figure);
        }

        public void DrawList(TextBox box)
        {
            foreach (var figure in listFigure)
            {
                box.Text += figure.Draw() + Environment.NewLine;
            }
        }
    }
}
