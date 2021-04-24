using System;

namespace Mid_No._3
{
    class Program
    {
        static void Main(string[] args)
        {

            string mode = Console.ReadLine(); ;
            double filmBackWidth = double.Parse(Console.ReadLine());
            int i = 1;

            Console.Write("String : ");

            
          
            while (i == 1)
            {
                Console.Write("Input a float filmBackWidth : ");

                filmBackWidth = float.Parse(Console.ReadLine());

                if (filmBackWidth > 0)
                {
                    double fLength, fov;

                    if (mode == "fLength")
                    {
                        i = 1;
                        while (i == 1)
                        {
                            Console.Write("Input a float fLength : ");
                            fLength = double.Parse(Console.ReadLine());
                            if (fLength > 0)
                            {
                                fov = 2 * (Math.Atan(filmBackWidth / (2 * fLength)));

                                Console.WriteLine("fLength = {0},fov = {1}", fLength, fov);
                                i = 2;
                            }
                            else 
                            {
                                Console.WriteLine("Invalid fLength. Please input again");
                            }
                        }
                    }
                    else
                    {
                        if (mode == "fov")
                        {
                            i = 1;

                            while (i == 1)
                            {
                                Console.Write("Input a float fov : ");
                                fov = float.Parse(Console.ReadLine());
                                if (fov > 0.1 && fov < 6.28)
                                {
                                    fLength = filmBackWidth / (2 * Math.Tan(fov / 2));
                                    Console.WriteLine("fLength = {0},fov = {1}", fLength, fov);
                                    i = 2;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid fov.Please input again");
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.Write("Invalid filmBackWidth. Please input again!!! ");
                }
            }
            
        }
    }
}
