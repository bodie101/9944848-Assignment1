﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    class ModeMedium
    {
        public static void G2()
        {

            int count2 = 0;
            int answer = 7;


            while (count2 <= 3)
            {
                if (count2 == 3)
                {
                    Console.Clear();

                    Console.WriteLine("Game over... You only get three tries ");
                    Console.ReadKey();
                    Console.Clear();
                    Results.Display();
                    


                    break;
                }

                Console.WriteLine("Enter a number between 1  & 10  ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input < answer)

                {
                    Console.WriteLine("Number is Higher, Try again");
                    count2++;
                    continue;
                }
                else if (input > answer)

                {
                    Console.WriteLine("Number is Lower, Try again");
                    count2++;
                    continue;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"YAAY... You Got it! The Number is {answer} !");
                    Console.ReadKey();
                    Console.Clear();
                    Results.Display();


                    break;
                }
            }
        }
    }
}

