using System;

namespace Mid_No._5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool breakfast = false;      
            bool Drink = false;
            int Dayofweek = int.Parse(Console.ReadLine());
            int TimeofDay = int.Parse(Console.ReadLine());
            bool OrderisnotAvailable = false;
            bool OrderError = false;

            for (int i = 1; i <= 5; i++)
            {
                string input = Console.ReadLine();
                if (input == "Breakfast Sef")
                {
                    breakfast = true;
                    Console.Write("Please enter a valid menu");
                }

                if (input == "Breakfast Set ")
                {
                    if (breakfast == false)
                    {
                        OrderisnotAvailable = true;
                        Console.Write("Sorry your order is not available");
                    }
                }

                if (input == "Weekend Set")
                {
                    OrderisnotAvailable = true;
                    Console.Write("Sorry your order is not available");
                }

                if (input == "Coffee")
                {
                    Drink = true;
                    Console.WriteLine("Sorry your order is out of stock");
                }
            }
            if (OrderError)
            {
                Console.WriteLine("Sorry your order is not available");
            }
           
            if ((breakfast == false && OrderisnotAvailable == false) || Drink == false)
            {
                Console.Write("End");
            }
          
            Console.ReadLine();

        }
    }
}
