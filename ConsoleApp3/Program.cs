// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            Console.WriteLine("Helooo Sharpister!!!!");

            Console.WriteLine("Здесь был Азамат");
            Console.WriteLine("что ты думаешь на счет всех? ");

            string str = Console.ReadLine();
            string rule = "все тупые";
            if (rule == str)
            {
                Console.WriteLine ($"поздровляю вы прошли проверку {rule}");;
            }
            else
            {
                Console.WriteLine("неверно");
                Console.WriteLine("Hello, World!");
                System.Console.WriteLine("Helooo Sharpister!!!!");
                global::System.Console.WriteLine("Test");
            }
            Console.ReadKey();
        } 
    }
 }


