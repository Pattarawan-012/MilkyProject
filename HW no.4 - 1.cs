using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
           bool Check = false;

            while (Check != true)
            {
                int Format;
                Format = int.Parse(Console.ReadLine());

                if (Format >= 0)
                {
                    Row(Format);

                    Check = true;
                }
                else
                {
                    Console.Write("Invalid Pascal’s triangle row number.");
                }
            }
        }


        static void Row(int row)
        {
            int n = 1, x, y;

            for (x = 0; x <= row; x++)
            {
                for (y = 0; y <= x; y++)
                {
                    if (y == 0 || x == 0)
                    {
                        n = 1;
                    }
                    else
                    {
                        n = n * (x - y + 1) / y;
                        Console.Write("{0}  ", n);
                    }
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }

    }
}