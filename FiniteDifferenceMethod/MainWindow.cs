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
        private double _beta = 1.2;
        private DisplayElement[][] _displayElementsValues2DArray;
        private DisplayElement[][] _displayElementsValues2DArrayCopy;
        private bool _drawingAllowed = true;
        private double _epsilon = 0.001;
        private bool _lastX;
        private double _maxValue = 0;
        private double _minValue = 1;
        private int _numberOfIterations;
        private int _pointIndex;
        private int _previousX = -1;
        private int _previousY = -1;

        public MainWindow()
        {
            InitializeComponent();
            DisplayColorMapButton.Enabled = false;
            ResultButton.Enabled = false;
            ResetButton.Enabled = false;
            DrawingFinishedButton.Enabled = false;

            IterationsTextBox.Enabled = false;
            _polygonPointsList = new List<Point>();


            _displayElementsValues2DArray = new DisplayElement[DrawArea.Height][];
            for (var i = 0; i < DrawArea.Height; i++)
            {
                _displayElementsValues2DArray[i] = new DisplayElement[DrawArea.Width];
                for (var j = 0; j < DrawArea.Width; j++)
                {
                    _displayElementsValues2DArray[i][j] = new DisplayElement(j, i);
                }
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
            ResetButton.Enabled = true;
            if (!_drawingAllowed) return;
            if (_pointIndex > 0)
            {
                if (_pointIndex > 1) DrawingFinishedButton.Enabled = true;
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
            DrawingFinishedButton.Enabled = true;
            _displayElementsValues2DArray = null;
            _displayElementsValues2DArrayCopy = null;
            _displayElementsValues2DArray = new DisplayElement[DrawArea.Height][];
            _displayElementsValues2DArrayCopy = new DisplayElement[DrawArea.Height][];

            for (var i = 0; i < DrawArea.Height; i++)
            {
                _displayElementsValues2DArray[i] = new DisplayElement[DrawArea.Width];
                for (var j = 0; j < DrawArea.Width; j++)
                {
                    _displayElementsValues2DArray[i][j] = new DisplayElement(j, i);
                    ((Bitmap) DrawArea.Image).SetPixel(j, i, Color.White);
                }
            }

            IterationsTextBox.Text = "";
            ResultButton.Enabled = false;
            DisplayColorMapButton.Enabled = false;

            DrawArea.Refresh();
            Refresh();
        }

        private void Finished_Click(object sender, EventArgs e)
        {
            ResultButton.Enabled = true;
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
            DrawingFinishedButton.Enabled = false;

            for (var i = 0; i < DrawArea.Height; i++)
            for (var j = 0; j < DrawArea.Width; j++)
            {
                if (!(_displayElementsValues2DArray[i][j].Value > -99)) continue;
                j++;
                if (_displayElementsValues2DArray[i][j].Value > -99) break;

                if (j >= _displayElementsValues2DArray[i].Length - 1) continue;

                while (true)
                {
                    _displayElementsValues2DArray[i][j++].Value = 0;
                    if (j >= _displayElementsValues2DArray[i].Length - 1) break;
                    if (_displayElementsValues2DArray[i][j].Value > -99) break;
                }
            }

            _displayElementsValues2DArrayCopy = new DisplayElement[DrawArea.Height][];
            for (var i = 0; i < DrawArea.Height; i++)
            {
                _displayElementsValues2DArrayCopy[i] = new DisplayElement[DrawArea.Width];
                for (var j = 0; j < DrawArea.Width; j++)
                {
                    _displayElementsValues2DArrayCopy[i][j] = new DisplayElement(
                        _displayElementsValues2DArray[i][j].Position, _displayElementsValues2DArray[i][j].Value);
                }
            }

            Refresh();
        }

        private void ApplyValuesButton_Click(object sender, EventArgs e)
        {
            _numberOfIterations = 0;

            _displayElementsValues2DArray = null;
            _displayElementsValues2DArray = new DisplayElement[DrawArea.Height][];
            for (var i = 0; i < DrawArea.Height; i++)
            {
                _displayElementsValues2DArray[i] = new DisplayElement[DrawArea.Width];
                for (var j = 0; j < DrawArea.Width; j++)
                {
                    _displayElementsValues2DArray[i][j] = new DisplayElement(
                        _displayElementsValues2DArrayCopy[i][j].Position, _displayElementsValues2DArrayCopy[i][j].Value);
                }
            }
            
            if (!double.TryParse(epsilonTextBox.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out _epsilon))
                MessageBox.Show(@"Invalid epsilon value", @"Invalid value");

            if (!double.TryParse(betaTextBox.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out _beta))
                MessageBox.Show(@"Invalid beta value", @"Invalid value");

            ResetButton.Enabled = true;
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
                if (Math.Abs(_displayElementsValues2DArray[i][j].Value - -99) < 0.0001) continue;
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
                                     _displayElementsValues2DArray[y[i] - 1][x[i]].Value +
                                     _displayElementsValues2DArray[y[i] + 1][x[i]].Value +
                                     _displayElementsValues2DArray[y[i]][x[i] - 1].Value +
                                     _displayElementsValues2DArray[y[i]][x[i] + 1].Value
                                 ) / 4.0);
                    if (Math.Abs(Math.Abs(tmpValue) - Math.Abs(_displayElementsValues2DArray[y[i]][x[i]].Value)) >
                        _epsilon)
                        isFinished = false;
                    if (tmpValue > _maxValue) _maxValue = tmpValue;
                    if (tmpValue < _minValue) _minValue = tmpValue;
                }
            }
            DisplayColorMapButton.Enabled = true;
            IterationsTextBox.Text = _numberOfIterations.ToString();
        }

        private void DisplayColorMapButton_Click(object sender, EventArgs e)
        {
            var step = (_maxValue + Math.Abs(_minValue)) / 11;
            DrawArea.Image = new Bitmap(DrawArea.Width, DrawArea.Height);
            var rightBorder = _minValue + step;
            var leftBorder = _minValue;

            Label[] labels =
            {
                LabelLevel0, LabelLevel1, LabelLevel2, LabelLevel3, LabelLevel4, LabelLevel5, LabelLevel6, LabelLevel7,
                LabelLevel8, LabelLevel9, LabelLevel10
            };

            foreach (var label in labels)
            {
                label.Text = rightBorder.ToString("F4") + @" - " + leftBorder.ToString("F4");
                leftBorder = rightBorder;
                rightBorder += step;
            }

            for (var i = 0; i < _displayElementsValues2DArray.Length; i++)
            for (var j = 0; j < _displayElementsValues2DArray[i].Length; j++)
            {
                if (Math.Abs(_displayElementsValues2DArray[i][j].Value - -99) < 0.0001)
                {
                    ((Bitmap) DrawArea.Image).SetPixel(j, i, Color.Black);
                    continue;
                }

                if (_displayElementsValues2DArray[i][j].Value > 0 &&
                    _displayElementsValues2DArray[i][j].Value <= step)
                {
                    ((Bitmap) DrawArea.Image).SetPixel(j, i, Color.DarkBlue);
                    continue;
                }

                if (_displayElementsValues2DArray[i][j].Value > step &&
                    _displayElementsValues2DArray[i][j].Value <= 2 * step)
                {
                    ((Bitmap) DrawArea.Image).SetPixel(j, i, Color.Blue);
                    continue;
                }

                if (_displayElementsValues2DArray[i][j].Value > 2 * step &&
                    _displayElementsValues2DArray[i][j].Value <= 3 * step)
                {
                    ((Bitmap) DrawArea.Image).SetPixel(j, i, Color.DeepSkyBlue);
                    continue;
                }

                if (_displayElementsValues2DArray[i][j].Value > 3 * step &&
                    _displayElementsValues2DArray[i][j].Value <= 4 * step)
                {
                    ((Bitmap) DrawArea.Image).SetPixel(j, i, Color.Aqua);
                    continue;
                }

                if (_displayElementsValues2DArray[i][j].Value > 4 * step &&
                    _displayElementsValues2DArray[i][j].Value <= 5 * step)
                {
                    ((Bitmap) DrawArea.Image).SetPixel(j, i, Color.Aquamarine);
                    continue;
                }

                if (_displayElementsValues2DArray[i][j].Value > 5 * step &&
                    _displayElementsValues2DArray[i][j].Value <= 6 * step)
                {
                    ((Bitmap) DrawArea.Image).SetPixel(j, i, Color.GreenYellow);
                    continue;
                }

                if (_displayElementsValues2DArray[i][j].Value > 6 * step &&
                    _displayElementsValues2DArray[i][j].Value <= 7 * step)
                {
                    ((Bitmap) DrawArea.Image).SetPixel(j, i, Color.Yellow);
                    continue;
                }

                if (_displayElementsValues2DArray[i][j].Value > 7 * step &&
                    _displayElementsValues2DArray[i][j].Value <= 8 * step)
                {
                    ((Bitmap) DrawArea.Image).SetPixel(j, i, Color.Gold);
                    continue;
                }

                if (_displayElementsValues2DArray[i][j].Value > 8 * step &&
                    _displayElementsValues2DArray[i][j].Value <= 9 * step)
                {
                    ((Bitmap) DrawArea.Image).SetPixel(j, i, Color.Orange);
                    continue;
                }

                if (_displayElementsValues2DArray[i][j].Value > 9 * step &&
                    _displayElementsValues2DArray[i][j].Value <= 10 * step)
                {
                    ((Bitmap) DrawArea.Image).SetPixel(j, i, Color.OrangeRed);
                    continue;
                }

                if (_displayElementsValues2DArray[i][j].Value > 10 * step &&
                    _displayElementsValues2DArray[i][j].Value <= _maxValue)
                    ((Bitmap) DrawArea.Image).SetPixel(j, i, Color.Red);
            }

            DrawArea.Refresh();
        }

        private void betaTextBox_TextChanged(object sender, EventArgs e)
        {
            ResultButton.Enabled = false;
            DisplayColorMapButton.Enabled = false;
        }

        private void epsilonTextBox_TextChanged(object sender, EventArgs e)
        {
            ResultButton.Enabled = false;
            DisplayColorMapButton.Enabled = false;
        }
    }
}