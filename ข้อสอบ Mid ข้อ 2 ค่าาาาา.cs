using System;

namespace Midtermexam
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x, y , run;            
            run = 0;
            x = a;
            y = b;
            while (run == 0)
            {
                if (x == y)
                {
                    Console.Write(x);
                    break;
                }
                else
                {
                    if (x < y)
                    {
                        Console.Write(x = x + a);
                    }
                    else
                    {
                        Console.Write(y = y + b);
                    }
                }
            }
            run++;
            Console.ReadLine();
        }




    }
}

