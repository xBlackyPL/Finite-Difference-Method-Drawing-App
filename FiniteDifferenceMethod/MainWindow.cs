using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace FiniteDifferenceMethod
{
    public partial class MainWindow : Form
    {
        private readonly List<Point> _polygonPointsList;
        private readonly DisplayElement[][] _displayElementsValues2DArray;
        private int _pointIndex;
        private double _epsilon = 0.0001;
        private double _beta = 0.1;
        private bool _drawingAllowed = true;
        private bool _lastX;
        private int _previousX = -1;
        private int _previousY = -1;
        private int _numberOfIterations = 0;

        public MainWindow()
        {
            InitializeComponent();
            IterationsTextBox.Enabled = false;
            _polygonPointsList = new List<Point>();
            _displayElementsValues2DArray = new DisplayElement[DrawArea.Height][];
            for (var i = 0; i < DrawArea.Height; i++)
            {
                _displayElementsValues2DArray[i] = new DisplayElement[DrawArea.Width];
                for (var j = 0; j < DrawArea.Width; j++) _displayElementsValues2DArray[i][j] = new DisplayElement(j, i);
            }


            betaTextBox.Text = _beta.ToString("F4", CultureInfo.InvariantCulture);
            epsilonTextBox.Text = _epsilon.ToString("F4", CultureInfo.InvariantCulture);
            linePotentialTextBox.Text = 1.ToString("F4", CultureInfo.InvariantCulture);
        }

        private void DrawArea_Paint(object sender, PaintEventArgs e)
        {
            var myPen = new Pen(Color.Black) {Width = 1};

            if (_pointIndex == 1)
            {
                e.Graphics.DrawLine(myPen, _polygonPointsList[0].X, _polygonPointsList[0].Y,
                    _polygonPointsList[0].X + 1,
                    _polygonPointsList[0].Y + 1);
                return;
            }

            for (var i = 1; i < _pointIndex; i++)
                e.Graphics.DrawLine(myPen, _polygonPointsList[i - 1], _polygonPointsList[i]);
        }

        private void DrawArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (!_drawingAllowed) return;
            if (_pointIndex > 0)
            {
                var xDiff = Math.Abs(_previousX - e.X);
                var yDiff = Math.Abs(_previousY - e.Y);


                if (xDiff > yDiff)
                {
                    _polygonPointsList.Add(new Point(e.X, _previousY));

                    if (_previousX > e.X)
                        for (var i = e.X; i <= _previousX; i++)
                            _displayElementsValues2DArray[_previousY][i].Value = double.Parse(linePotentialTextBox.Text,
                                CultureInfo.InvariantCulture);
                    else
                        for (var i = _previousX; i <= e.X; i++)
                            _displayElementsValues2DArray[_previousY][i].Value = double.Parse(linePotentialTextBox.Text,
                                CultureInfo.InvariantCulture);

                    _previousX = e.X;
                    _lastX = true;
                }
                else
                {
                    _polygonPointsList.Add(new Point(_previousX, e.Y));

                    if (_previousY > e.Y)
                        for (var i = e.Y; i <= _previousY; i++)
                            _displayElementsValues2DArray[i][_previousX].Value = double.Parse(linePotentialTextBox.Text,
                                CultureInfo.InvariantCulture);
                    else
                        for (var i = _previousY; i <= e.Y; i++)
                            _displayElementsValues2DArray[i][_previousX].Value = double.Parse(linePotentialTextBox.Text,
                                CultureInfo.InvariantCulture);

                    _previousY = e.Y;
                    _lastX = false;
                }

                _pointIndex++;
            }
            else
            {
                _previousX = e.X;
                _previousY = e.Y;
                _polygonPointsList.Add(new Point(e.X, e.Y));
                _pointIndex++;
            }

            Refresh();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            _drawingAllowed = true;
            _polygonPointsList.Clear();
            _pointIndex = 0;
            Finished.Enabled = true;
            Refresh();
        }

        private void Finished_Click(object sender, EventArgs e)
        {
            if (_polygonPointsList[_pointIndex - 1] != _polygonPointsList[0])
                if (_lastX)
                {
                    var newY = _polygonPointsList[0].Y + 5;
                    var newX = _polygonPointsList[0].X;

                    _polygonPointsList.Add(new Point(_previousX, newY));
                    if (_previousY > newY)
                        for (var i = newY; i <= _previousY; i++)
                            _displayElementsValues2DArray[i][_previousX].Value = double.Parse(linePotentialTextBox.Text,
                                CultureInfo.InvariantCulture);
                    else
                        for (var i = _previousY; i <= newY; i++)
                            _displayElementsValues2DArray[i][_previousX].Value = double.Parse(linePotentialTextBox.Text,
                                CultureInfo.InvariantCulture);

                    _previousY = newY;
                    _polygonPointsList.Add(new Point(newX, newY));
                    if (_previousX > newX)
                        for (var i = newX; i <= _previousX; i++)
                            _displayElementsValues2DArray[_previousY][i].Value = double.Parse(linePotentialTextBox.Text,
                                CultureInfo.InvariantCulture);
                    else
                        for (var i = _previousX; i <= newX; i++)
                            _displayElementsValues2DArray[_previousY][i].Value = double.Parse(linePotentialTextBox.Text,
                                CultureInfo.InvariantCulture);

                    newY = _polygonPointsList[0].Y;
                    _polygonPointsList.Add(new Point(newX, newY));
                    if (_previousY > newY)
                        for (var i = newY; i <= _previousY; i++)
                            _displayElementsValues2DArray[i][_previousX].Value = double.Parse(linePotentialTextBox.Text,
                                CultureInfo.InvariantCulture);
                    else
                        for (var i = _previousY; i <= newY; i++)
                            _displayElementsValues2DArray[i][_previousX].Value = double.Parse(linePotentialTextBox.Text,
                                CultureInfo.InvariantCulture);

                    _pointIndex += 3;
                }
                else
                {
                    var newY = _polygonPointsList[0].Y;
                    var newX = _polygonPointsList[0].X;

                    _polygonPointsList.Add(new Point(newX, _previousY));
                    if (_previousX > newX)
                        for (var i = newX; i <= _previousX; i++)
                            _displayElementsValues2DArray[_previousY][i].Value = double.Parse(linePotentialTextBox.Text,
                                CultureInfo.InvariantCulture);
                    else
                        for (var i = _previousX; i <= newX; i++)
                            _displayElementsValues2DArray[_previousY][i].Value = double.Parse(linePotentialTextBox.Text,
                                CultureInfo.InvariantCulture);

                    _previousX = newX;
                    _polygonPointsList.Add(new Point(newX, newY));
                    if (_previousY > newY)
                        for (var i = newY; i <= _previousY; i++)
                            _displayElementsValues2DArray[i][_previousX].Value = double.Parse(linePotentialTextBox.Text,
                                CultureInfo.InvariantCulture);
                    else
                        for (var i = _previousY; i <= newY; i++)
                            _displayElementsValues2DArray[i][_previousX].Value = double.Parse(linePotentialTextBox.Text,
                                CultureInfo.InvariantCulture);

                    _previousY = newY;
                    _pointIndex += 2;
                }

            _drawingAllowed = false;
            Finished.Enabled = false;

            for (var i = 0; i < DrawArea.Height; i++)
            for (var j = 0; j < DrawArea.Width; j++)
            {
                if (!(_displayElementsValues2DArray[i][j].Value > -1)) continue;
                j++;
                if (_displayElementsValues2DArray[i][j].Value > -1) break;

                if (j >= _displayElementsValues2DArray[i].Length - 1) continue;

                while (true)
                {
                    _displayElementsValues2DArray[i][j++].Value = 0;
                    if (j >= _displayElementsValues2DArray[i].Length - 1) break;
                    if (_displayElementsValues2DArray[i][j].Value > -1) break;
                }
            }

            Refresh();
        }

        private void ApplyValuesButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(epsilonTextBox.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out _epsilon))
                MessageBox.Show(@"Invalid epsilon value", @"Invalid value");

            if (!double.TryParse(betaTextBox.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out _beta))
                MessageBox.Show(@"Invalid beta value", @"Invalid value");
        }

        private void Result_Click(object sender, EventArgs e)
        {
            var x = new List<int>();
            var y = new List<int>();
            _numberOfIterations = 0;

            for (var i = 0; i < _displayElementsValues2DArray.Length; i++)
            for (var j = 0; j < _displayElementsValues2DArray[i].Length; j++)
            {
                if (!(Math.Abs(_displayElementsValues2DArray[i][j].Value) < 0.0001)) continue;
                if (Math.Abs(_displayElementsValues2DArray[i][j].Value - (-1)) < 0.0001) continue;
                x.Add(j);
                y.Add(i);
            }

            var isFinished = false;
            while (!isFinished)
            {
                _numberOfIterations++;
                isFinished = true;

                for (var i = 0; i < x.Count; i++)
                {
                    var tmpValue = _displayElementsValues2DArray[y[i]][x[i]].Value;

                    _displayElementsValues2DArray[y[i]][x[i]].Value =
                        (1 - _beta) * _displayElementsValues2DArray[y[i]][x[i]].Value +
                        _beta * ((
                                     _displayElementsValues2DArray[y[i]-1][x[i]].Value +
                                     _displayElementsValues2DArray[y[i ]+1][x[i]].Value +
                                     _displayElementsValues2DArray[y[i]][x[i]-1].Value +
                                     _displayElementsValues2DArray[y[i]][x[i]+1].Value
                                 ) / 4.0);
                    if (Math.Abs(tmpValue - _displayElementsValues2DArray[y[i]][x[i]].Value) > _epsilon)
                        isFinished = false;
                }
            }

            IterationsTextBox.Text = _numberOfIterations.ToString();
        }
    }
}