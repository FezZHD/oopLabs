using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace graphicEditor
{
    public partial class MainForm : Form
    {
        private Shape NewShape;
        private List<IFigureCreator> figureCreators;
        private IFigureCreator Creator { get; set; }
        private bool IsDrawing { get; set; }
        private uint[] CurrentPoints = new uint[2];
        private int _currentPointsCount;
        Graphics graphicCanvas;
        private Bitmap imageBitmap;



        public MainForm()
        {

            InitializeComponent();
          
            imageBitmap = new Bitmap(canvas.Width, canvas.Height);
            graphicCanvas = Graphics.FromImage(imageBitmap);
            figureCreators = new List<IFigureCreator>
            {
                new CreateLine(),
                new CreateTriangle(),
                new CreateRectangle(),
                new CreateCircle(),
                new CreateEllipse(),
                new CreatePentagon(),
            };
        }


        private void ButtonClick(object sender, EventArgs e)
        {
            _currentPointsCount = 0;
            Control send = (Control) sender;
            Creator = figureCreators[int.Parse(send.Tag.ToString())];
            IsDrawing = true;
            NewShape = Creator.GetShape();
        }


        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {

            if ((!IsDrawing) || (Creator == null))
            {
                return;
            }

            CurrentPoints[0] = (ushort)Convert.ToInt32(e.X);
            CurrentPoints[1] = (ushort)Convert.ToInt32(e.Y) ;

            
            NewShape.AddToList(CurrentPoints);

            _currentPointsCount++;
            if (_currentPointsCount == NewShape.PointCounter)
            {
                NewShape.Draw(graphicCanvas,NewShape._pointsList);
                canvas.Image = imageBitmap;
                NewShape._pointsList.Clear();
                _currentPointsCount = 0;
            }
        }

        private void ClearClick(object sender, EventArgs e)
        {
            graphicCanvas.Clear(Color.White);
            canvas.Image = imageBitmap;
        }
    }
}

