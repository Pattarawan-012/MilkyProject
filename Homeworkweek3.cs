using System;

namespace Homeworkweek3
{
    class Program
    {
        static void Main(string[] args)
        {
            string agency;
            int passwords;
            Console.Write("Input your password : ");
            passwords = int.Parse(Console.ReadLine());
            Console.Write("Input your agency : ");
            agency = Console.ReadLine();

            if (agency == "CIA")
            {
                bool checkfirststep = (passwords - 3) % 10 == 0 || (passwords - 6) % 10 == 0 || (passwords - 9) % 10 == 0;
                bool checksecondstep = checkfirststep && (passwords % 100) / 10 != 1 &&
                                       (passwords % 100) / 10 != 3 &&
                                       (passwords % 100) / 10 != 5;
                bool checkthirdstep = checksecondstep && (passwords % 10000) / 1000 >= 6 &&
                                       (passwords % 1000) / 1000 != 8;
                Console.Write(checkthirdstep);

            }
            else if (agency == "FBI")
            {
                bool checkfirststep = (passwords % 1000000) / 100000 >= 4 && (passwords % 1000000) / 100000 <= 7;
                bool checksecondstep = checkfirststep && (passwords % 1000) / 100 == 2 || (passwords % 1000) / 100 == 4 || (passwords % 1000) / 100 == 8;
                bool checkthirdstep = checksecondstep && ((passwords % 100000) / 10000) % 2 == 1;
                Console.Write(checkthirdstep);
            }
             else if (agency == "NSA")
            {
                bool checkfirststep = 30 % (passwords % 10) == 0;
                bool checksecondstep = checkfirststep && (passwords % 10000) % 3 == 0 && (passwords % 10000) % 2 == 1;
                bool checkthirdstep = checksecondstep && passwords % 10 == 7 ||
                    (passwords % 100) / 10 == 7 || (passwords % 1000) / 100 == 7 ||
                    (passwords % 10000) / 1000 == 7 ||
                    (passwords % 100000) / 1000 == 7 ||
                    (passwords % 1000000) / 100000 == 7;
                Console.Write(checkthirdstep);     
            }
            else
            {
                Console.WriteLine("Your passwords is wrong");
            }
            Console.ReadLine();


        }
    }
}
