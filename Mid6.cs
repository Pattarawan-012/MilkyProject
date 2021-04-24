using System;

namespace Mid_No._6
{
    class Program
    {
        static void Main(string[] args)
        {


            int column, row, step;
            int i, x, j;
            
            s = char.Parse(Console.ReadLine());

           
            column = int.Parse(Console.ReadLine());

            int realwidth = column;
          

            row = int.Parse(Console.ReadLine());
           

            step = int.Parse(Console.ReadLine());


            for (j = 0; j < step; j++)
            {
                for (x = 0; x < row; x++)
                {
                    for (x = 0;  i < column; i++)
                    {
                        Console.Write("{0}", s);
                    }
                    Console.Write("\n");
                }
                column += realwidth;
            }
           
        }
    }
}
