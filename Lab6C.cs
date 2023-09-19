/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab6C
*/

using System;
using System.Reflection.Metadata.Ecma335;

class Lab6C
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome!\nYou have $1000 in your account.");
        int balance = 1000;
        int withrdaw, deposit;
        char cntue;
        do
        {
            Console.WriteLine("\nMenu \n0 – Make a deposit \n1 – Make a withdrawal \n2 – Display account value");
            Console.Write("\nPlease make a selection: ");
            int choice= int.Parse(Console.ReadLine());
            switch(choice){
                case 0:
                    Console.Write("How much would you like to deposit? : ");
                    deposit = int.Parse(Console.ReadLine());
                    balance = balance + deposit;
                    Console.WriteLine("Your current balance is $"+balance);
                    break;
                case 1:
                    Console.Write("How much would you like to withdraw? : ");
                    withrdaw = int.Parse(Console.ReadLine());
                    balance= balance - withrdaw;
                    Console.WriteLine("Your current balance is $" + balance);
                    break;
                case 2:
                    Console.WriteLine("Your current balance is $"+balance);
                    break;
                default:
                    Console.WriteLine("Invalid entry, please try again.");
                    break;
            }
            Console.Write("Would you like to return to the main menu (Y/N)? : ");
            cntue= char.Parse(Console.ReadLine());
        } while (cntue=='Y'||cntue=='y');
        Console.WriteLine("\nThank you for banking with us!");
    }
}
