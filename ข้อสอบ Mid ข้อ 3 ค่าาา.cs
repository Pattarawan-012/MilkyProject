using System;

namespace Mid3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numofBox, numofBucket, Playerwin = 0, run = 0;
            Console.Write("Bucket No.1 : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Bucket No.2 : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Bucket No.3 : ");
            int c = int.Parse(Console.ReadLine());

            while (run == 0)
            {
                if (a <= 0 && b <= 0 && c <= 0)
                {
                    run = 1;
                    if (Playerwin % 2 == 0)
                    {
                        Console.WriteLine("Player A is winner <3 ");
                    }
                    else
                    {
                        Console.WriteLine("Player B is winner <3 ");
                    }
                }
                else
                {
                    Console.WriteLine("What you gonna pick?");
                    Console.WriteLine("BucketA '1' \nBucketB '2' \nBucketC '3'");
                    numofBox = int.Parse(Console.ReadLine());

                    Console.WriteLine("How many box you pick?");
                    numofBucket = int.Parse(Console.ReadLine());

                    Playerwin++;
                    if (numofBucket == 1 || numofBucket == 2)
                    {
                        if (numofBox == 1)
                        {
                            Console.Write(a = a - numofBucket);
                        }
                        if (numofBox == 2)
                        {
                            Console.Write(b = c - numofBucket);
                        }
                        if (numofBox == 3)
                        {
                            Console.WriteLine(c = c - numofBucket);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Again!");
                    }
                }
            }
        }
    }
}

