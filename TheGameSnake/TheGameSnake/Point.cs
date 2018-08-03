using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameSnake
{
    class Point
    {
        public int x;  // The cursor position by X
        public int y;  // The cursor position by Y
        public char sym;  // The symbol which draw on console

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public void Draw()  // Draw the symbol
        {
            Console.SetCursorPosition(x, y);  // Change the cursor position
            Console.Write(sym);  // Print the char
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move(int offset, Diraction diraction)
        {
            if (diraction == Diraction.Right)
            {
                x = x + offset;
            }
            else if (diraction == Diraction.Left)
            {
                x = x - offset;
            }
            else if (diraction == Diraction.Up)
            {
                y = y + offset;
            }
            else if (diraction == Diraction.Down)
            {
                y = y - offset;
            }
        }
        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }
    }
}
