using System;
using System.Linq;

namespace _06.Rectangle_Position
{
    public class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Wigth { get; set; }
        public int Height { get; set; }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }
        public int Right
        {
            get
            {
                return Left + Wigth;
            }
        }

        public bool IsInside(Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) && (r.Top <= Top) && (r.Bottom >= Bottom);
        }
    }
 

    public class Program
    {
        public static void Main(string[] args)
        {
            Rectangle r1 = ReadRectangle();
            Rectangle r2 = ReadRectangle();

            Console.WriteLine(r1.IsInside(r2)? "Inside": "Not inside");

        }


        private static Rectangle ReadRectangle()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle r = new Rectangle();
            r.Top = input[1];
            r.Left = input[0];
            r.Wigth = input[2];
            r.Height = input[3];

            return r;

        }
    }
}