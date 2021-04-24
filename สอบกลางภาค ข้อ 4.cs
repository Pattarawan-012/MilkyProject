using System;

namespace Mid_No._4
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            float X1, Y1;
            float X2, Y2;
            float dx, dy;
            float step;
            int  a , b ;
            a = Math.Abs(dx);
            b = Math.Abs(dy);


            Console.Write("input float X1:");
            X1 = float.Parse(Console.ReadLine());

            Console.Write("input float Y1:");
            Y1 = float.Parse(Console.ReadLine());

            Console.Write("input float X2:");
            X2 = float.Parse(Console.ReadLine());

            Console.Write("input float Y2:");
            Y2 = float.Parse(Console.ReadLine());

            dx = X2 - X1;
            dy = Y2 - Y1;

            if (a >= b)
            {
                step = Math.Abs(dx);
                dx /= step;
                dy /= step;
                x = X1;
                y = Y1;
                int i = 1;


                while (i <= step)
                {
                    Console.WriteLine("{0},{1}", x, y);
                    x += dx;
                    y += dy;
                    i++;
                }
            }
            else
            {
                step = b;
                dx /= step;
                dy /= step;
                x = X1;
                y = Y1;
                int i = 1;


                while (i <= step)
                {
                    Console.WriteLine("{0},{1}", x, y);
                    x += dx;
                    y += dy;
                    i++;
                }
            }
            Console.ReadLine();
        }
    }
}
