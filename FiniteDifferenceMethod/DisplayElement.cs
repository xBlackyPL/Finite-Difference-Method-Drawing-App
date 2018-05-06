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
            Value = -1;
        }

        public Point Position { get; set; }
        public double Value;
    }
}
