using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace graphicEditor
{
    public partial class MainForm : Form
    {
        private Shape _newShape;
        private List<Shape> Shapes = new List<Shape>(); 
        private List<IFigureCreator> _figureCreators;
        private IFigureCreator Creator { get; set; }
        private bool IsDrawing { get; set; }
        private uint[] _currentPoints = new uint[2];
        private int _currentPointsCount;
        Graphics _graphicCanvas;
        private Bitmap _imageBitmap;
        public Color SelectedColor = Color.Black;



        public MainForm()
        {

            InitializeComponent();
          
            _imageBitmap = new Bitmap(canvas.Width, canvas.Height);
            _graphicCanvas = Graphics.FromImage(_imageBitmap);
            _figureCreators = new List<IFigureCreator>
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
            Creator = _figureCreators[int.Parse(send.Tag.ToString())];
            IsDrawing = true;
            _newShape = Creator.GetShape();
        }


        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {

            if ((!IsDrawing) || (Creator == null))
            {
                return;
            }

            _currentPoints[0] = (ushort)Convert.ToInt32(e.X);
            _currentPoints[1] = (ushort)Convert.ToInt32(e.Y) ;

            
            _newShape.AddToList(_currentPoints);

            _currentPointsCount++;
            if (_currentPointsCount == _newShape.PointCounter)
            {
                _newShape._brushColor = SelectedColor;
                _newShape.Thinkness = (int) ThiknessValue.Value;
                _newShape.Draw(_graphicCanvas);
                canvas.Image = _imageBitmap;
                Shapes.Add(_newShape);
                //list.add()
                _newShape = Creator.GetShape();

               //_newShape._pointsList.Clear();
                _currentPointsCount = 0;
            }
        }

        private void ClearClick(object sender, EventArgs e)
        {
            _graphicCanvas.Clear(Color.White);
            canvas.Image = _imageBitmap;
        }

        private void SelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog selectColor = new ColorDialog();
            if (selectColor.ShowDialog() == DialogResult.OK)
            {
                SelectedColor = selectColor.Color;
            }

        }
    }
}

