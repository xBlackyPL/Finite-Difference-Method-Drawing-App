using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteDifferenceMethod
{
    internal class DisplayElement
    {
        public DisplayElement(int x, int y, double val)
        {
            Position = new Point(x,y);
            Value = val;
        }

        public DisplayElement(int x, int y)
        {
            Position = new Point(x,y);
            Value = -99;
        }

        public DisplayElement(Point point, double val)
        {
            Position = new Point(point.X,point.Y);
            Value = val;
        }

        public Point Position { get; set; }
        public double Value;
    }
}
