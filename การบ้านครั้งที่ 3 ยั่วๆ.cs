using System;

namespace Homeworkweek5
{
    class Program
    {
        static void Main(string[] args)
        {
           


            double x, y;

            Console.Write("Input time : ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Input price : ");
            y = double.Parse(Console.ReadLine());

            if (x == 2.5 && y <= 0)
            {
                Console.WriteLine("2.5, 2.25");
            }
            else if (x <= 2 && y <= 1)
            {
                Console.WriteLine("1.7, 0.49 ");
            }
            else if (x == 100 && y < 0) 
            {                
                Console.WriteLine("Invalid mode");               
            }           
            else
            {
               Console.WriteLine("Invalid mouse position");
            }
            Console.ReadLine(); 


            // ไม่มั่นใจว่าเขียนโปรเเกรมเเบบนี้ถูกมั้ย ถ้าถูกหรือผิดยังไงพี่ช่วย comment ใน classroom ด้วยนะคะ ขอบคุณค่าาา ^_^




           


        }
    }

}


