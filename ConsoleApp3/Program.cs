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

            string str = Console.ReadLine();
            string rule = "все тупые";
            if (rule == str)
            {
                Console.WriteLine("поздровляю вы прошли проверку");
            }
            else
            {
                Console.WriteLine("неверно");

            }          
        } 
    }
 }