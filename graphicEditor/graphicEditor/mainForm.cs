using System;
using System.Windows.Forms;

namespace graphicEditor
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void LineButtonClick(object sender, EventArgs e)
        {
            try
            {
                uint firstCordinate = Convert.ToUInt32(firstCoordinate.Text);
                uint secondCordinate = Convert.ToUInt32(secondCoordinate.Text);
                Line newLine = new Line(firstCordinate, secondCordinate);
                textList.Text += newLine.DrawLine();
            }
            catch
            {
                MessageBox.Show(@"Ошибка в обработке кординаты");
            }
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            try
            {
                uint firstCordinate = Convert.ToUInt32(firstCoordinate.Text);
                uint secondCordinate = Convert.ToUInt32(secondCoordinate.Text);
                uint thirdCordinate = Convert.ToUInt32(thirdCoordinate.Text);
                Triangle newTriangle = new Triangle(firstCordinate, secondCordinate,thirdCordinate);
                textList.Text += newTriangle.DrawTriangle();
            }
            catch
            {
                MessageBox.Show(@"Ошибка в обработке кординаты");
            }
        }

    }
}
