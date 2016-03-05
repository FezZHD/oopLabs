using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace graphicEditor
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            InitText();
        }

        private List<TextBox> listTextBoxs= new List<TextBox>();
        private List<uint> currentCoor;

        private void InitText()
        {
            listTextBoxs.Add(firstCoordinate);
            listTextBoxs.Add(secondCoordinate);
            listTextBoxs.Add(thirdCoordinate);
            listTextBoxs.Add(fouthCoordinate);
            listTextBoxs.Add(fifthCoordinate);
        }

        private List<uint> getCordinates(uint count)
        {
            List<uint> listCoordinates = new List<uint>();

            for (int i = 0; i < count; i++)
            {
                try
                {
                    listCoordinates.Add(Convert.ToUInt32(listTextBoxs[i].Text));
                }
                catch
                {
                    MessageBox.Show(@"Ошибка в обработке кординаты");
                    return null;
                }
            }
            return listCoordinates;
        }

        private void Pentagon_Click(object sender, EventArgs e)
        {
            currentCoor = getCordinates(5);
            if (currentCoor != null)
            {
                Pentagon newPentagon = new Pentagon(currentCoor[0], currentCoor[1], currentCoor[2], currentCoor[3], currentCoor[4]);
                textList.Text += newPentagon.Draw();
            }
           
        }
    

        private void Ellipse_Click(object sender, EventArgs e)
        {
            currentCoor = getCordinates(3);
            if (currentCoor != null)
            {
                MyEllipse newEllipse = new MyEllipse(currentCoor[0], currentCoor[1], currentCoor[2]);
                textList.Text += newEllipse.Draw();
            }

        }

        private void DrawAll_Click(object sender, EventArgs e)
        {

            currentCoor = getCordinates(5);
            if (currentCoor != null)
            {
                FigureList newFigureList = new FigureList();

                Pentagon newPentagon = new Pentagon(currentCoor[0], currentCoor[1], currentCoor[2], currentCoor[3], currentCoor[4]);
                newFigureList.AddFigure(newPentagon);

                MyCircle newCircle = new MyCircle(currentCoor[0],currentCoor[1]);
                newFigureList.AddFigure(newCircle);

                Line newLine = new Line(currentCoor[0],currentCoor[1]);
                newFigureList.AddFigure(newLine);

                Triangle newTriangle = new Triangle(currentCoor[0], currentCoor[1], currentCoor[2]);
                newFigureList.AddFigure(newTriangle);

                MyRectanlge newRectangle = new MyRectanlge(currentCoor[0], currentCoor[1], currentCoor[2],currentCoor[3]);
                newFigureList.AddFigure(newRectangle);

                MyEllipse newEllipse = new MyEllipse(currentCoor[0], currentCoor[1], currentCoor[2]);
                newFigureList.AddFigure(newEllipse);

                newFigureList.DrawList(textList);
            }
        }

        private void CircleClick(object sender, EventArgs e)
        {
            currentCoor = getCordinates(2);
            if (currentCoor != null)
            {
                MyCircle newCircle = new MyCircle(currentCoor[0], currentCoor[1]);
                textList.Text += newCircle.Draw();
            }
        }
    

        private void LineButtonClick(object sender, EventArgs e)
        {
            currentCoor = getCordinates(2);
            if (currentCoor != null)
            {
                Line newLine = new Line(currentCoor[0],currentCoor[1]);
                textList.Text += newLine.Draw();
            }
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            currentCoor = getCordinates(3);
            if (currentCoor != null)
            {
                Triangle newTriangle = new Triangle(currentCoor[0], currentCoor[1], currentCoor[2]);

                textList.Text += newTriangle.Draw();
            }             
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            currentCoor = getCordinates(4);
            if (currentCoor != null)
            {
                MyRectanlge newRectangle = new MyRectanlge(currentCoor[0], currentCoor[1], currentCoor[2], currentCoor[3]);
                textList.Text += newRectangle.Draw();
            }
            
        }

    }
}

