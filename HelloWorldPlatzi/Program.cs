﻿using System;
using System.Collections.Generic;

namespace HelloWorldPlatzi
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            bool continueSoftwareExecution = false;
            while (continueSoftwareExecution == true)
            {
                Console.WriteLine("Do you wish to keep the software running? write 1 if yes, 0 if no");
                int keepGoing = Convert.ToInt16(Console.ReadLine());
                if (keepGoing==1)
                {
                    Console.WriteLine("Hello workd! The software will keep running");
                    continueSoftwareExecution = true;
                }
                else if (keepGoing==0)
                {
                    Console.WriteLine("This is the last time the software is running");
                    continueSoftwareExecution = false;
                }
                else
                {
                    Console.WriteLine("Invalid input, Try Again");
                    continueSoftwareExecution = true;
                }
            }


            do
            {
                Console.WriteLine("Do you wish to keep the software running? write 1 if yes, 0 if no");
                int keepGoing = Convert.ToInt16(Console.ReadLine());
                if (keepGoing == 1)
                {
                    Console.WriteLine("Hello workd! The software will keep running");
                    continueSoftwareExecution = true;
                }
                else if (keepGoing == 0)
                {
                    Console.WriteLine("This is the last time the software is running");
                    continueSoftwareExecution = false;
                }
                else
                {
                    Console.WriteLine("Invalid input, Try Again");
                    continueSoftwareExecution = true;
                }
            } while (continueSoftwareExecution == true);


        }
    }
}
