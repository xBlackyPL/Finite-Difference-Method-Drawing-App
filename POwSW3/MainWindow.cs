using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POwSW3
{
    public partial class MainWindow : Form
    {
        private List<int[]> linesPointsList = null;
        private List<double> linePotentiaList = null;
        private int lineIndex = 0;
        private int pointIndex = 0;
        private double epsilon = 0.0001;
        private double beta = 0.1;
        private bool drawingAllowed = true;

        public MainWindow()
        {
            InitializeComponent();
            linesPointsList = new List<int[]>();
            linePotentiaList = new List<double>();
            betaTextBox.Text = beta.ToString("F4", CultureInfo.InvariantCulture);
            epsilonTextBox.Text = epsilon.ToString("F4", CultureInfo.InvariantCulture);
            linePotentialTextBox.Text = 1.ToString("F4", CultureInfo.InvariantCulture);
        }


        private void DrawArea_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Black);
            myPen.Width = 2;

            if (pointIndex == 1)
            {
                e.Graphics.DrawLine(myPen, linesPointsList[0][0], linesPointsList[0][1], linesPointsList[0][0] + 1,
                    linesPointsList[0][1] + 1);
                return;
            }

            for (int i = 1; i < pointIndex; i++)
            {
                e.Graphics.DrawLine(myPen, linesPointsList[i - 1][0], linesPointsList[i - 1][1],
                    linesPointsList[i][0], linesPointsList[i][1]);
            }
        }

        private void DrawArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawingAllowed)
            {
                if (pointIndex > 0)
                {
                    var xDiff = Math.Abs(linesPointsList[pointIndex - 1][0] - e.X);
                    var yDiff = Math.Abs(linesPointsList[pointIndex - 1][1] - e.Y);

                    if (xDiff > yDiff)
                    {
                        linesPointsList.Add(new int[2] { e.X, linesPointsList[pointIndex - 1][1] });
                    }
                    else
                    {
                        linesPointsList.Add(new int[2] { linesPointsList[pointIndex - 1][0], e.Y });
                    }

                    linePotentiaList.Add(double.Parse(linePotentialTextBox.Text, CultureInfo.InvariantCulture));
                    pointIndex++;
                    lineIndex++;
                }
                else
                {
                    linesPointsList.Add(new int[2] { e.X, e.Y });
                    linePotentiaList.Add(double.Parse(linePotentialTextBox.Text, CultureInfo.InvariantCulture));
                    pointIndex++;
                }

                Refresh();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            drawingAllowed = true;
            linesPointsList.Clear();
            linePotentiaList.Clear();
            lineIndex = 0;
            pointIndex = 0;
            Finished.Enabled = true;
            Refresh();
        }

        private void Finished_Click(object sender, EventArgs e)
        {
            if ((linesPointsList[pointIndex - 1][0] != linesPointsList[0][0]) &&
                (linesPointsList[pointIndex - 1][1] != linesPointsList[0][1]))
            {
                linesPointsList.Add(new int[2] { linesPointsList[0][0], linesPointsList[pointIndex - 1][1] });
                pointIndex++;
                lineIndex++;
                linePotentiaList.Add(double.Parse(linePotentialTextBox.Text, CultureInfo.InvariantCulture));
                linesPointsList.Add(new int[2] { linesPointsList[0][0], linesPointsList[0][1] });
                pointIndex++;
                lineIndex++;
                linePotentiaList.Add(double.Parse(linePotentialTextBox.Text, CultureInfo.InvariantCulture));
            }
            drawingAllowed = false;
            Refresh();
            Finished.Enabled = false;
        }
    }
}
