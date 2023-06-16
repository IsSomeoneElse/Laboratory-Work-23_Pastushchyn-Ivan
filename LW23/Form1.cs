using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW23
{
    public partial class Form1 : Form
    {
        private const double Interval = 0.1; // Інтервал між точками
        private double a; // Коефіцієнт
        private int GraphScale; // Масштаб

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scaleNumericUpDown.Minimum = 1;
            scaleNumericUpDown.Maximum = 10;
            scaleNumericUpDown.ReadOnly = true;
        }

        private void DrawGraph()
        {
            Bitmap graphBitmap = new Bitmap(graphPictureBox.Width, graphPictureBox.Height);
            using (Graphics g = Graphics.FromImage(graphBitmap))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                g.Clear(Color.White);

                if (!double.TryParse(CoefficientATextBox.Text, out a))
                {
                    MessageBox.Show("Invalid input!");
                    return;
                }

                for (double t = -10; t <= 10; t += Interval)
                {
                    double x = a * (t - Math.Pow(Math.Sin(t), 2));
                    double y = a * (t - Math.Pow(Math.Cos(t), 2));

                    int pixelX = (int)(graphPictureBox.Width / 2 + x * GraphScale);
                    int pixelY = (int)(graphPictureBox.Height / 2 - y * GraphScale);

                    g.FillEllipse(Brushes.DarkRed, pixelX - 2, pixelY - 2, 4, 4);
                }

                int centerX = graphPictureBox.Width / 2;
                int centerY = graphPictureBox.Height / 2;
                g.DrawLine(Pens.Black, 0, centerY, graphPictureBox.Width, centerY);
                g.DrawLine(Pens.Black, centerX, 0, centerX, graphPictureBox.Height);

                Font axisLabelFont = new Font(FontFamily.GenericSansSerif, 8);
                SizeF xAxisLabelSize = g.MeasureString("x", axisLabelFont);
                g.DrawString("x", axisLabelFont, Brushes.Black, graphPictureBox.Width - xAxisLabelSize.Width - 5, centerY - 15);
                g.DrawString("y", axisLabelFont, Brushes.Black, centerX + 5, 5);
            }

            graphPictureBox.Image = graphBitmap;
        }

        private void drawGraphButton_Click(object sender, EventArgs e)
        {
            GraphScale = int.Parse(scaleNumericUpDown.Text) * 10;
            DrawGraph();
        }

        private void CoefficientATextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (CoefficientATextBox.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (CoefficientATextBox.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    drawGraphButton.Focus();
                return;
            }
            e.Handled = true;
        }
    }
}