/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab6A
*/

using System;

class Lab6A
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter 10 numbers and this program will display the largest.\n");
        int number = 0, N_number = 0;
        int count = 1;
        for(; count <= 10;)
        {
            Console.Write("Please enter number" + count + ": ");
            N_number= int.Parse(Console.ReadLine());
            if (N_number > number)
            {
                number = N_number;
            }
            count++;
        }
        Console.WriteLine("\nThe largest number was "+number);
    }
}
