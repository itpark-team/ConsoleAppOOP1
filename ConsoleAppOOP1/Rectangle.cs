using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP1
{
    internal class Rectangle
    {
        private int _x1, _y1, _x2, _y2;

        public Rectangle()
        {
            _x1 = _x2 = _y1 = _y2 = 0;
        }

        public Rectangle(int x1, int y1, int x2, int y2)
        {
            _x1 = x1;
            _y1 = y1;
            _x2 = x2;
            _y2 = y2;
        }

        public int X1
        {
            get { return _x1; }
            set
            {
                if (value >= 0 && value < _x2)
                {
                    _x1 = value;
                }
            }
        }

        public int GetWidth()
        {
            return _x2 - _x1;
        }

        public int GetHeight()
        {
            return _y1 - _y2;
        }

        public int GetArea()
        {
            return GetWidth() * GetHeight();
        }

        public int GetPerimeter()
        {
            return 2 * (GetWidth() + GetHeight());
        }
    }
}
