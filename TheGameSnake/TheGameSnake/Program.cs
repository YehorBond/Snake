using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameSnake
{
    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.BackgroundColor = ConsoleColor.Red;
            //Point p1 = new Point(1, 3, '*');
            //p1.Draw();
            

            //Point p2 = new Point(4, 5, '#');
            //p2.Draw();

            HorizontalLine lineTop = new HorizontalLine(0, (Console.LargestWindowWidth - 1), 0, ' ');
            lineTop.Draw();
            HorizontalLine lineBottom = new HorizontalLine(0, (Console.LargestWindowWidth - 1), (Console.LargestWindowHeight - 1), ' ');
            lineBottom.Draw();
            VerticalLine lineLeft = new VerticalLine(0, (Console.LargestWindowHeight - 1), 0, ' ');
            lineLeft.Draw();
            VerticalLine lineRight = new VerticalLine(0, (Console.LargestWindowHeight - 1), (Console.LargestWindowWidth - 1), ' ');
            lineRight.Draw();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Point p = new Point(10, 10, '*');
            Snake snake = new Snake(p, 4, Diraction.Right);
            snake.Draw();
            snake.Move();
            Console.ReadKey();
        }
    }
}
