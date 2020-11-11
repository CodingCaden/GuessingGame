/******************************************

 *    Ma'Caden Miles

 *    Mini-Projects - OCT 28, 2020

 ******************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(" Do You want to play? (Again)\n Type: 'yes'");
            string reply = Console.ReadLine();

            if (reply == "yes")
            {
                PlayGame();
            }
            else
            {
                Environment.Exit(0);
            }
        }


        static void PlayGame()
        {
            try
            {
                int attempts = 0;
                bool win = false;
                Random random = new Random();
                int num = random.Next(0, 100);

                do
                {
                    Console.WriteLine("Guess a number between 0 and 100");
                    string sguess = Console.ReadLine();
                    int guess = int.Parse(sguess);

                    if (guess > num)
                    {
                        Console.WriteLine("Too High!");
                        attempts++;

                    }
                    else if (guess < num)
                    {
                        Console.WriteLine("Too Low!");
                        attempts++;
                    }
                    else if (guess == num)
                    {
                        Console.WriteLine("CORRECT! You Win!\n You had " + attempts + " attempts!");
                        win = true;
                        Main(null);
                    }



                } while (win == false);
                {
                    Console.WriteLine("Enter a 'NUMBER'");
                    Main(null);
                }
            }catch(FormatException f)
            {
                Console.WriteLine("Enter a number");
                Main(null);
            }
        }

     }
    }
