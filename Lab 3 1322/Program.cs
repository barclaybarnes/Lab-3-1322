using Lab_3_1322;
using System;
using System.IO;

class Driver
{
    public static void Main(string[] args)
    {
        Quiz q1 = new Quiz();
        int x = 0;
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1) Add Question");
            Console.WriteLine("2) Remove Question");
            Console.WriteLine("3) Modify Question");
            Console.WriteLine("4) Take the Quiz");
            Console.WriteLine("5) Quit");

            x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    q1.AddQuestion();

                    break;






            }




        }
    }
}