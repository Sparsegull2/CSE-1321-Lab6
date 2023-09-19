/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab6B 
*/

using System;

class Lab6B
{

    public static void Main(string[] args)
    {
        Console.Write("Enter a number between 1 and 1000: ");
        int number= int.Parse(Console.ReadLine());
        int count = 0;
        while (number >= 1 && number <= 1000)
        {
            Random rnd = new Random();
            int guess = rnd.Next(1000)+1;
            Console.WriteLine("My guess was "+guess);
            count++;
            if (guess == number) 
            { 
                Console.WriteLine("\nI guessed the number was "+guess+" and it only took me " +count+" guesses ");
                break;
            }
        }
        if (number < 1 || number > 1000)
        {
            Console.WriteLine("Invalid input");
        }
    }
}
