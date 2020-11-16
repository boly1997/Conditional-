﻿using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your time in this Format (e.g. 19:00);");
            string time = Console.ReadLine(); // deberia de ser 00:20
            if (time.Length != 5)
            {
                Console.WriteLine("Invalid Format or Hour");
            }
            else 
            {
                var hoursAndMinutes= time.Split(":"); // esto me regresa ["00","20"]
                var hoursInt = new int[1] { Convert.ToInt32(hoursAndMinutes[0]) };
                var minutesInt = new int[1] { Convert.ToInt32(hoursAndMinutes[1]) };

                if (hoursInt[0] >= 00 && hoursInt[0] <= 23 && minutesInt[0] >= 00 && minutesInt[0] <= 59)
                {
                    Console.WriteLine("ALL ITS ALRIGHT");
                }
                else
                {
                    Console.WriteLine("Invalid input");

                }
            }

        }
    }
}
